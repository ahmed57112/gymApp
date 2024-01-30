using gymApi.Models.Domain;
using gymApi.Models.DTO;
using gymApi.Repository;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace gymApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    
    public class MEMBERController : ControllerBase
    {
        private readonly IMEMBER memberAction;

        public MEMBERController(GYMDbContext dbContext,IMEMBER mEMBER)
        {

            DbContext = dbContext;
            memberAction = mEMBER;
        }

        public GYMDbContext DbContext { get; }
        [HttpGet]
        [Route("GetData")]
        public async Task<IActionResult> GetData()
        {
           // var data =await DbContext.MEMBERs.ToListAsync();
            var data = await memberAction.getDataAsync();
            

            //map domainModel to Dto

            var DataDto = new List<MEMBER_DTO_GET>();
            foreach (var member in data)
            {
                DataDto.Add(new MEMBER_DTO_GET()
                {
                    ID = member.ID,
                    NAME = member.NAME,
                    NATIONAL_ID = member.NATIONAL_ID,
                    MEMBER_TYPE = member.MEMBER_TYPE

                });
            }

            return Ok(DataDto);
        }


        [HttpPost]
        [Route("addData")]

        public async Task<IActionResult> addData([FromBody] MEMBER_DTO_BASE mEMBER_DTO_BASE)
        {
            try
            {
                // convert dto to model

                var dataModel = new MEMBER
                {
                   //ID = maxId + 1,
                    NAME = mEMBER_DTO_BASE.NAME,
                    NATIONAL_ID = mEMBER_DTO_BASE.NATIONAL_ID,
                    MEMBER_TYPE = mEMBER_DTO_BASE.MEMBER_TYPE

                };
            var data =  await memberAction.addDataAsync(dataModel);
                
                return Ok(data);

            }
            catch(Exception e)
            {
                return BadRequest("failed");

            }
            

        }

        [HttpPut]
        [Route("EditData/{id:int}")]
        public async Task<IActionResult> EditData([FromRoute] int id, [FromBody] MEMBER_DTO_BASE mEMBER_DTO_BASE)
        {
            var result =await memberAction.editDataAsync(id, mEMBER_DTO_BASE);

            if(result == "edited")
            {
                return Ok(result);
            }
            else
            {
                return NotFound();
            }


        }

        [HttpDelete]
        [Route("deleteData/{id:int}")]

        public async Task<IActionResult> deleteData([FromRoute] int id)
        {
            var dataToBeDeleted =await DbContext.MEMBERs.FindAsync(id);

          if(  dataToBeDeleted == null)
            {
                return NotFound("notFound");

            }
            else
            {
                DbContext.Remove(dataToBeDeleted);
               await DbContext.SaveChangesAsync();
                return Ok("deleted");
            }

        }

    }
}
