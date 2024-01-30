using gymApi.Models.Domain;
using gymApi.Models.DTO;
using Microsoft.AspNetCore.Mvc;

public interface IMEMBER
    {
        Task<List<MEMBER>> getDataAsync();
        Task<string> addDataAsync(MEMBER MEMBER);
        Task<string> editDataAsync(int id, MEMBER_DTO_BASE mEMBER_DTO_BASE);
    }

