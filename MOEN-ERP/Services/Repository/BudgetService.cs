using DevExpress.ClipboardSource.SpreadsheetML;
using Microsoft.Extensions.Options;
using MOEN_ERP.Models.Common;
using MOEN_ERP.Models.Data;
using MOEN_ERP.Models.ViewModel;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace MOEN_ERP.Services.Repository
{
    public interface IBudgetService
    {
        public Task<List<BudgetRequestViewModel>> GetBudgetListAsync(BudgetRequestFilter data);
        public Task<BudgetRequestDetailViewModel> GetBudgetRequestDetail(int id);
        public Task<BudgetRequestDetailViewModel> SaveBudgetList(BudgetRequestForm data);
        public void DeleteBudgetRequest(int id);
    }
    public class BudgetService : IBudgetService
    {
        private readonly SettingsModel _settings;
        private readonly ITokenService _tokenService;

        public BudgetService(IOptions<SettingsModel> options, ITokenService tokenService)
        {
            _settings = options.Value;
            _tokenService = tokenService;
        }

        public async Task<List<BudgetRequestViewModel>> GetBudgetListAsync(BudgetRequestFilter data)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            List<BudgetRequestViewModel> result = new List<BudgetRequestViewModel>();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Budget/GetBudgetListAsync?BudgetYear={data.BudgetYear}&OrganizationId={data.OrganizationId}&StatusId={data.StatusId}";
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                //var cotentData = JsonConvert.SerializeObject(data);
                var request = new HttpRequestMessage();
                request.Method = HttpMethod.Get;
                //request.Content = new StringContent(cotentData, Encoding.UTF8, "application/json");
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", userCur?.UserToken);
                request.RequestUri = new Uri(url);


                var response = _httpClient.SendAsync(request).ConfigureAwait(false);

                var res = response.GetAwaiter().GetResult();

                res.EnsureSuccessStatusCode();
                if (res.IsSuccessStatusCode)
                {
                    var json = await res.Content.ReadAsStringAsync();
                    result = JsonConvert.DeserializeObject<List<BudgetRequestViewModel>>(json);

                }

            }
            catch (Exception ex)
            {
                throw;
            }
            return result;
        }

        public async Task<BudgetRequestDetailViewModel> GetBudgetRequestDetail(int id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            BudgetRequestDetailViewModel result = new BudgetRequestDetailViewModel();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Budget/BudgetRequestDetail?id={id}";
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                //var cotentData = JsonConvert.SerializeObject(data);
                var request = new HttpRequestMessage();
                request.Method = HttpMethod.Get;
                //request.Content = new StringContent(cotentData, Encoding.UTF8, "application/json");
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", userCur?.UserToken);
                request.RequestUri = new Uri(url);


                var response = _httpClient.SendAsync(request).ConfigureAwait(false);

                var res = response.GetAwaiter().GetResult();

                res.EnsureSuccessStatusCode();
                if (res.IsSuccessStatusCode)
                {
                    var json = await res.Content.ReadAsStringAsync();
                    result = JsonConvert.DeserializeObject<BudgetRequestDetailViewModel>(json);

                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return result;
        }


        public async Task<BudgetRequestDetailViewModel> SaveBudgetList(BudgetRequestForm data)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            BudgetRequestDetailViewModel result = new BudgetRequestDetailViewModel();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Budget/SaveBudgetList";
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                var cotentData = JsonConvert.SerializeObject(data);
                var request = new HttpRequestMessage();
                request.Method = HttpMethod.Post;
                request.Content = new StringContent(cotentData, Encoding.UTF8, "application/json");
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", userCur?.UserToken);
                request.RequestUri = new Uri(url);


                var response = _httpClient.SendAsync(request).ConfigureAwait(false);

                var res = response.GetAwaiter().GetResult();

                res.EnsureSuccessStatusCode();
                if (res.IsSuccessStatusCode)
                {
                    var json = await res.Content.ReadAsStringAsync();
                    result = JsonConvert.DeserializeObject<BudgetRequestDetailViewModel>(json);

                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return result;
        }

        public async void DeleteBudgetRequest(int id)
        {
            var userCur = new Appz(MyHttpContext.Current)?.CurrentSignInUser;

            BudgetRequestDetailViewModel result = new BudgetRequestDetailViewModel();
            try
            {
                //var token = await _tokenService.GetTokenAsync();
                var url = $"{_settings.BaseUrlApi}/Budget/DeleteBudgetRequest?id={id}";
                HttpClientHandler handler = new HttpClientHandler();
                using var _httpClient = new HttpClient(handler, false);
                //var cotentData = JsonConvert.SerializeObject(data);
                var request = new HttpRequestMessage();
                request.Method = HttpMethod.Delete;
                //request.Content = new StringContent(cotentData, Encoding.UTF8, "application/json");
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", userCur?.UserToken);
                request.RequestUri = new Uri(url);


                var response = _httpClient.SendAsync(request).ConfigureAwait(false);

                var res = response.GetAwaiter().GetResult();

                res.EnsureSuccessStatusCode();
                if (res.IsSuccessStatusCode)
                {
                    //var json = await res.Content.ReadAsStringAsync();
                    //result = JsonConvert.DeserializeObject<BudgetRequestDetailViewModel>(json);

                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }


    }
}
