using LinqKit;
using Microsoft.EntityFrameworkCore;
using MOEN_ERP.DAL.Models;
using MOEN_ERP.Models.Data;

namespace MOEN_ERP.API.Services.Repository
{
    public interface IBudgetService
    {
        public Task<List<VBudgetRequest>> GetBudgetListAsync(BudgetRequestFilter data);
        public Task<BudgetRequestDetail> BudgetRequestDetail(int id);
        public Task<BudgetRequestDetail> SaveBudgetList(BudgetRequestForm data);

        public void DeleteBudgetRequest(int id);
    }
    public class BudgetService : IBudgetService
    {
        MOENDBContext context;
        public BudgetService(MOENDBContext _context)
        {
            context = _context;
        }

        public async Task<List<VBudgetRequest>> GetBudgetListAsync(BudgetRequestFilter data)
        {
            try
            {
                var whr = PredicateBuilder.True<VBudgetRequest>();
                if (!string.IsNullOrEmpty(data.BudgetYear)) whr = whr.And(x => x.BudgetYear.ToString().Contains(data.BudgetYear));
                if (data.OrganizationId != null) whr = whr.And(x => x.OrganizationId == data.OrganizationId);
                if (data.StatusId != null) whr = whr.And(x => x.StatusId == data.StatusId);

                return await context.VBudgetRequests.Where(whr).ToListAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<BudgetRequestDetail> BudgetRequestDetail(int id)
        {
            try
            {
                var data = await context.VBudgetRequests
                    .Where(x => x.Id == id)
                    .Select(x => new BudgetRequestDetail
                    {
                        BudgetYear = x.BudgetYear,
                        OrganizationId = x.OrganizationId,
                        StatusId = x.StatusId,
                        Code = x.Code,
                        TotalRequestAmount = x.TotalRequestAmount,
                    })
                    .FirstOrDefaultAsync();

                return data;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<BudgetRequestDetail> SaveBudgetList(BudgetRequestForm data)
        {
            try
            {
                BudgetRequest budgetRequest = new BudgetRequest();
                if (string.IsNullOrEmpty(data.Code))
                {
                    // get lasted ID
                    var lastId = context.BudgetRequests.OrderByDescending(x => x.Id).FirstOrDefaultAsync().Result.Id;
                    budgetRequest = new BudgetRequest
                    {
                        BudgetYear = data.BudgetYear,
                        OrganizationId = data.OrganizationId,
                        StatusId = data.StatusId,
                        Code = $"{lastId + 1}/{data.BudgetYear}"
                    };
                    context.BudgetRequests.Add(budgetRequest);
                }
                else
                {
                    // update data
                    budgetRequest = context.BudgetRequests.Where(x=>x.Code == data.Code).FirstOrDefaultAsync().Result;
                    budgetRequest.BudgetYear = data.BudgetYear;
                    budgetRequest.OrganizationId = data.OrganizationId;
                    budgetRequest.StatusId = data.StatusId;

                }

                context.SaveChanges();

                var insertedData = new BudgetRequestDetail
                {
                    BudgetYear = budgetRequest.BudgetYear,
                    OrganizationId = budgetRequest.OrganizationId,
                    StatusId = budgetRequest.StatusId,
                    Code = budgetRequest.Code,
                    TotalRequestAmount = budgetRequest.TotalRequestAmount,
                };

                return insertedData;
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        public void DeleteBudgetRequest(int id)
        {
            try
            {
                var data = context.BudgetRequests.Where(x => x.Id == id).FirstOrDefault();
                context.BudgetRequests.Remove(data);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        public void SaveBudgetGovernment()
        {
            try
            {
                // Save data to BudgetGovernment
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
