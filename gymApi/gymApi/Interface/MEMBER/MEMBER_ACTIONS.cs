
using gymApi.Models.Domain;
using gymApi.Models.DTO;
using gymApi.Repository;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class MEMBER_ACTIONS : IMEMBER
{

    private readonly GYMDbContext dbContext;

    public MEMBER_ACTIONS(GYMDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<List<MEMBER>> getDataAsync()
    {
        return await dbContext.MEMBERs.ToListAsync();

    }

    public async Task<string> addDataAsync(MEMBER member)
    {
       
       await dbContext.AddAsync(member);
        await dbContext.SaveChangesAsync();

        return "donsse";
    }

    public async Task<string> editDataAsync(int id, MEMBER_DTO_BASE mEMBER_DTO_BASE)
    {

        var dataToBeEdited =await dbContext.MEMBERs.FindAsync(id);
        
        if (dataToBeEdited == null)
        {
            return  "notFouned";
        }
        else
        {
            dataToBeEdited.NATIONAL_ID = mEMBER_DTO_BASE.NATIONAL_ID;
            dataToBeEdited.NAME = mEMBER_DTO_BASE.NAME;
            dataToBeEdited.MEMBER_TYPE = mEMBER_DTO_BASE.MEMBER_TYPE;
            await dbContext.SaveChangesAsync();
            return ("edited");
        }


    }
}

