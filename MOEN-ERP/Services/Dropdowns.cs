using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.Xpo.Helpers;
using DevExpress.XtraRichEdit.Model;
using MOEN_ERP.Models.Common;
using MOEN_ERP.Models.Data;
using MOEN_ERP.Models.RawData;
using MOEN_ERP.Models.ViewModel.MeetingRoomBooking;
using MOEN_ERP.Services.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Linq;
using MOEN_ERP.DAL.Models;

namespace MOEN_ERP.Services
{
    public interface IDropdowns
    {
        public Task<List<SelectListItem>> DropdownStatus();
        public Task<List<SelectListItem>> DropdownStatusString();
        public Task<List<SelectListItem>> DropdownAssetChangeType();
        public Task<List<SelectListItem>> DropdownERPBookingStatus();
        public Task<List<SelectListItem>> DropdownVehicleOwnership();
        public Task<List<SelectListItem>> DropdownVehicleBrand();
        public Task<List<SelectListItem>> DropdownVehicleModel(int? VehicleBrandId = null);
        public Task<List<SelectListItem>> DropdownVehicleType();
        public Task<List<SelectListItem>> DropdownVehicleRegistration();
        public Task<List<SelectListItem>> DropdownVehicleTypeRegistration();
        public Task<List<SelectListItem>> DropdownFuelType();
        public Task<List<SelectListItem>> DropdownOfficer(int? WorkPositionId = null);
        public Task<List<SelectListItem>> DropdownMeetingRoomDirectorApprove(int? OrganizationId, List<int>? SystemRoleIdIn);
        public Task<List<SelectListItem>> DropdownOrganization(string[]? OrganizationLevelNotIn = null, string[]? OrganizationLevelIn = null, string[]? DivisionTypeIn = null, int[]? ParentOrganizationIn = null, string? FieldName = "NameThai");
        public Task<List<SelectListItem>> DropdownConferenceApplication();
        public Task<List<SelectListItem>> DropdownFoodCategory(int?[] DisplayTypeIn = null);
        public Task<List<SelectListItem>> DropdownGarage();
        public Task<List<SelectListItem>> DropdownVehicleMaintenanceType();
        public Task<List<SelectListItem>> DropdownAudioVisualService();
        public Task<List<SelectListItem>> DropdownAssetLicenseNumber(int?[] AssetIdNotIn = null, int? AssetTypeId = null);
        public Task<List<SelectListItem>> DropdownNamePrefix();
        public Task<List<SelectListItem>> DropdownAudioVisualDevice();
        public Task<List<SelectListItem>> DropdownAudioVisualDeviceStatus();
        public Task<List<SelectListItem>> DropdownVehicleBookingFormat();
        public Task<List<SelectListItem>> DropdownVehicleBookingStatus();
        public Task<List<SelectListItem>> DropdownVehicleBookingType();
        public Task<List<SelectListItem>> DropdownVehicleBookingDirector();
        public Task<List<SelectListItem>> DropdownVehicleBookingDirectorByUserId();

        public Task<List<SelectListItem>> DropdownFoodCategoryDisplayType();
        public Task<List<SelectListItem>> DropdownMeetingRoom();
        public Task<List<SelectListItem>> DropdownMeetingRoomBookingType();
        public Task<List<SelectListItem>> DropdownBookingStatus();
        public Task<List<SelectListItem>> DropdownVideoConferenceBookingPriority();
        public Task<List<SelectListItem>> DropdownVideoConferenceLicense();
        public Task<List<SelectListItem>> DropdownVehicleForAssign(int VehicleBookingId, int? VehicleTypeId = null);
        public Task<List<SelectListItem>> DropdownDriverForAssign(int VehicleBookingId);

        public Task<List<SelectListItem>> DropdownFuelCode();

        public Task<List<SelectListItem>> DropdownBudgetExpenseType(string? IsParent = null);
        public Task<List<SelectListItem>> DropdownUnit();

    }
    public class Dropdowns : IDropdowns
    {
        private readonly IMasterService _masterService;
        private readonly IDataService _dataService;
        private readonly IRawDataService _rawDataService;
        public Dropdowns(IMasterService masterService, IRawDataService rawService, IDataService dataService, IRawDataService rawDataService)
        {
            _masterService = masterService;
            _dataService = dataService;
            _rawDataService = rawDataService;
        }

        public async Task<List<SelectListItem>> DropdownStatus()
        {
            var results = new List<SelectListItem>();
            results.Add(new SelectListItem { Value = "true", Text = "ใช้งาน" });
            results.Add(new SelectListItem { Value = "false", Text = "ไม่ใช้งาน" });

            return results;
        }

        public async Task<List<SelectListItem>> DropdownStatusString()
        {
            var results = new List<SelectListItem>();
            results.Add(new SelectListItem { Value = "Y", Text = "ปฏิบัติงาน" });
            results.Add(new SelectListItem { Value = "N", Text = "ไม่มาปฏิบัติงาน" });

            return results;
        }

        public async Task<List<SelectListItem>> DropdownAssetChangeType()
        {
            var results = new List<SelectListItem>();
            results.Add(new SelectListItem { Value = "1", Text = "ยืม" });
            results.Add(new SelectListItem { Value = "2", Text = "คืน" });

            return results;
        }

        public async Task<List<SelectListItem>> DropdownERPBookingStatus()
        {
            var results = new List<SelectListItem>();
            results.Add(new SelectListItem { Value = "W", Text = "ส่งเรื่อง" });
            results.Add(new SelectListItem { Value = "B", Text = "ส่งกลับแก้ไข" });
            results.Add(new SelectListItem { Value = "A", Text = "อนุมัติค่าใช้จ่าย" });
            results.Add(new SelectListItem { Value = "V", Text = "ยกเลิก" });

            return results;
        }
        public async Task<List<SelectListItem>> DropdownVehicleOwnership()
        {
            var results = new List<SelectListItem>();
            MasterVehicleOwnership sch = new MasterVehicleOwnership()
            {
                Active = true,
            };
            var data = await _masterService.GetMasterVehicleOwnershipListAsync(sch);
            results = data.OrderBy(x => x.Name).Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Name }).ToList();
            return results;
        }

        public async Task<List<SelectListItem>> DropdownVehicleBrand()
        {
            var results = new List<SelectListItem>();
            MasterVehicleBrand sch = new MasterVehicleBrand()
            {
                Active = true,
            };
            var data = await _masterService.GetMasterVehicleBrandList(sch);
            results = data.OrderBy(x => x.Name).Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Name }).ToList();
            return results;
        }

        public async Task<List<SelectListItem>> DropdownVehicleModel(int? VehicleBrandId = null)
        {
            var results = new List<SelectListItem>();
            MasterVehicleModel sch = new MasterVehicleModel()
            {
                Active = true,
                VehicleBrandId = VehicleBrandId
            };
            var data = await _masterService.GetMasterVehicleModelList(sch);
            results = data.OrderBy(x => x.Name).Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Name }).ToList();
            return results;
        }

        public async Task<List<SelectListItem>> DropdownVehicleType()
        {
            var results = new List<SelectListItem>();
            MasterVehicleType sch = new MasterVehicleType()
            {
                Active = true,
            };
            var data = await _masterService.GetMasterVehicleTypeList(sch);
            results = data.OrderBy(x => x.Name).Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Name }).ToList();
            return results;
        }

        public async Task<List<SelectListItem>> DropdownVehicleRegistration()
        {
            var results = new List<SelectListItem>();
            Vehicle sch = new Vehicle()
            {
                Active = true,
            };
            var data = await _dataService.GetVehicleListAsync(sch);
            results = data.OrderBy(x => x.VehicleRegistration).Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.VehicleRegistration }).ToList();
            return results;
        }

        public async Task<List<SelectListItem>> DropdownVehicleTypeRegistration()
        {
            var results = new List<SelectListItem>();
            VVehicle sch = new VVehicle()
            {
                VehicleActive = true,
            };
            var data = await _rawDataService.GetViewVehicleListAsync(sch);
            results = data.OrderBy(x => x.VehicleRegistration).Select(x => new SelectListItem { Value = x.VehicleId.ToString(), Text = x.VtypeName + " ทะเบียน " + x.VehicleRegistration }).ToList();
            return results;
        }

        public async Task<List<SelectListItem>> DropdownFuelType()
        {
            var results = new List<SelectListItem>();
            MasterFuelType sch = new MasterFuelType()
            {
                Active = true,
            };
            var data = await _masterService.GetMasterFuelTypeList(sch);
            results = data.OrderBy(x => x.Name).Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Name }).ToList();
            return results;
        }


        public async Task<List<SelectListItem>> DropdownOfficer(int? WorkPositionId = null)
        {
            var results = new List<SelectListItem>();
            VOfficer sch = new VOfficer();
            sch.Active = true;
            if (WorkPositionId != null) sch.WorkPositionId = WorkPositionId;

            var data = await _rawDataService.GetViewOfficerListAsync(sch);
            results = data.OrderBy(x => x.FullName).Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.FullName }).ToList();
            return results;
        }


        public async Task<List<SelectListItem>> DropdownMeetingRoomDirectorApprove(int? OrganizationId, List<int>? SystemRoleIdIn)
        {
            var results = new List<SelectListItem>();

            //var listSystemRoel = new List<int> {1 };
            
            var dataRawOfficer = await _rawDataService.GetViewOfficerListAsync(new VOfficer { Active =true });
            var dataRawRoleAssign = await _rawDataService.GetViewSystemUserRoleAssignListAsync(new VSystemUserRoleAssign());

            var dataOffice = (from o in dataRawOfficer
                            join s in dataRawRoleAssign
                            on o.SystemUserId equals s.SystemUserId
                            where o.Active == true && SystemRoleIdIn.Contains((int)s.SystemRoleId) && o.OrganizationId == OrganizationId
                            select o);

            results = dataOffice.OrderBy(x => x.FullName).Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.FullName }).ToList();
            return results;
        }




        public async Task<List<SelectListItem>> DropdownOrganization(string[]? OrganizationLevelNotIn = null, string[]? OrganizationLevelIn = null, string[]? DivisionTypeIn = null,  int[]? ParentOrganizationIn = null, string? FieldName = "NameThai")
        {
            var results = new List<SelectListItem>();
            VMasterOrganization sch = new VMasterOrganization();
            sch.Active = "Y";
            
            var data = await _rawDataService.GetViewMasterOrganizationListAsync(sch);

            if (OrganizationLevelNotIn != null && OrganizationLevelNotIn.Length > 0)
            {
                //foreach (var itm in OrganizationLevelNotIn)
                //{
                //    data = data.Where(x => x.OrganizationLevel != itm.ToString()).ToList();
                //}
                data = data.Where(x => !OrganizationLevelNotIn.Contains(x.OrganizationLevel)).ToList();
            }

            if (OrganizationLevelIn != null && OrganizationLevelIn.Length > 0)
            {
                //foreach (var itm in OrganizationLevelIn)
                //{
                //    data = data.Where(x => x.OrganizationLevel == itm.ToString()).ToList();
                //}
                data = data.Where(x => OrganizationLevelIn.Contains(x.OrganizationLevel)).ToList();
            }


            if (DivisionTypeIn != null && DivisionTypeIn.Length > 0)
            {
                //foreach (var itm in DivisionTypeIn)
                //{
                //    data = data.Where(x => x.DivisionType == itm.ToString()).ToList();
                //}
                data = data.Where(x => DivisionTypeIn.Contains(x.DivisionType)).ToList();
            }

            if (ParentOrganizationIn != null && ParentOrganizationIn.Length > 0)
            {
                foreach (var itm in ParentOrganizationIn)
                {
                    data = data.Where(x => x.ParentOrganization == itm).ToList();
                }
            }

           
            if (FieldName == "NameThai")
            {
                //Issue 331
                results = data.OrderBy(x => x.NameThai).Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.NameThai }).ToList();
            }
            else if(FieldName == "OrganizationName")
            {
                results = data.OrderBy(x => x.OrganizationName).Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.OrganizationName }).ToList();
            }




            return results;
        }


        public async Task<List<SelectListItem>> DropdownConferenceApplication()
        {
            var results = new List<SelectListItem>();
            MasterVideoConference sch = new MasterVideoConference()
            {
                Active = true,
            };
            var data = await _masterService.GetMasterVideoConferenceListAsync(sch);
            results = data.Where(x=>x.Name != null).OrderBy(x => x.Name).Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Name }).ToList();
            return results;
        }

        public async Task<List<SelectListItem>> DropdownUnit()
        {
            var results = new List<SelectListItem>();

            var data = await _masterService.GetMasterUnitListAsync();
            results = data.Where(x => x.NameThai != null).OrderBy(x => x.NameThai).Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.NameThai }).ToList();
            return results;
        }

        public async Task<List<SelectListItem>> DropdownFoodCategory(int?[] DisplayTypeIn = null)
        {
            var results = new List<SelectListItem>();
            MasterFoodCategory sch = new MasterFoodCategory()
            {
                Active = true,
            };
            var data = await _masterService.GetMasterFoodCategoryListAsync(sch);
            if (DisplayTypeIn != null)
            {
                data = data.Where(x => DisplayTypeIn.Contains(x.DisplayType)).ToList();
            }

            results = data.OrderBy(x => x.Name).Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Name }).ToList();
            return results;
        }

        public async Task<List<SelectListItem>> DropdownGarage()
        {
            var results = new List<SelectListItem>();
            MasterGarage sch = new MasterGarage()
            {
                Active = true,
            };
            var data = await _masterService.GetMasterGarageList(sch);
            results = data.OrderBy(x => x.Name).Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Name }).ToList();
            return results;
        }

        public async Task<List<SelectListItem>> DropdownVehicleMaintenanceType()
        {
            var results = new List<SelectListItem>();
            MasterVehicleMaintenanceType sch = new MasterVehicleMaintenanceType()
            {
                Active = true,
            };
            var data = await _masterService.GetMasterVehicleMaintenanceTypeList(sch);
            results = data.OrderBy(x => x.Name).Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Name }).ToList();
            return results;
        }

        public async Task<List<SelectListItem>> DropdownAudioVisualService()
        {
            var results = new List<SelectListItem>();
            AudioVisualService sch = new AudioVisualService()
            {
                Active = true,
            };
            var data = await _dataService.GetAudioVisualServiceListAsync(sch);
            results = data.OrderBy(x => x.Name).Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Name }).ToList();
            return results;
        }

        public async Task<List<SelectListItem>> DropdownAssetLicenseNumber(int?[] AssetIdNotIn = null, int? AssetTypeId = null)
        {
            var results = new List<SelectListItem>();
            Asset sch = new Asset()
            {
                AssetTypeId = AssetTypeId,
            };
            var data = await _dataService.GetAssetListAsync(sch);
            if (AssetIdNotIn != null && AssetIdNotIn.Count() > 0) data = data.Where(x => !AssetIdNotIn.Contains(x.Id)).ToList();

            results = data.OrderBy(x => x.LicenseNumber).Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.LicenseNumber }).ToList();
            return results;
        }


        public async Task<List<SelectListItem>> DropdownNamePrefix()
        {
            var results = new List<SelectListItem>();
            MasterNamePrefix sch = new MasterNamePrefix()
            {
                Active = true,
            };
            var data = await _masterService.GetMasterNamePrefixListAsync(sch);
            results = data.OrderBy(x => x.NamePrefix).Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.NamePrefix }).ToList();
            return results;
        }


        public async Task<List<SelectListItem>> DropdownAudioVisualDevice()
        {
            var results = new List<SelectListItem>();
            AudioVisualDevice sch = new AudioVisualDevice()
            {
                Active = true,
            };
            var data = await _dataService.GetAudioVisualDeviceListAsync(sch);
            results = data.OrderBy(x => x.Name).Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Name }).ToList();
            return results;
        }

        public async Task<List<SelectListItem>> DropdownAudioVisualDeviceStatus()
        {
            var results = new List<SelectListItem>();
            MasterAudioVisualDeviceStatus sch = new MasterAudioVisualDeviceStatus()
            {
                Active = true,
            };
            var data = await _masterService.GetMasterAudioVisualDeviceStatusListAsync(sch);
            results = data.OrderBy(x => x.Name).Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Name }).ToList();
            return results;
        }

        public async Task<List<SelectListItem>> DropdownVehicleBookingFormat()
        {
            var results = new List<SelectListItem>();
            MasterVehicleBookingFormat sch = new MasterVehicleBookingFormat()
            {
                Active = true,
            };
            var data = await _masterService.GetMasterVehicleBookingFormatListAsync(sch);
            results = data.OrderBy(x => x.Name).Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Name }).ToList();
            return results;
        }

        public async Task<List<SelectListItem>> DropdownVehicleBookingStatus()
        {
            var results = new List<SelectListItem>();
            MasterVehicleBookingStatus sch = new MasterVehicleBookingStatus()
            {
                Active = true,
            };
            var data = await _masterService.GetMasterVehicleBookingStatusListAsync(sch);
            results = data.OrderBy(x => x.StatusName).Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.StatusName }).ToList();
            return results;
        }

        public async Task<List<SelectListItem>> DropdownVehicleBookingType()
        {
            var results = new List<SelectListItem>();
            MasterVehicleBookingType sch = new MasterVehicleBookingType()
            {
                Active = true,
            };
            var data = await _masterService.GetMasterVehicleBookingTypeListAsync(sch);
            results = data.OrderBy(x => x.Name).Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Name }).ToList();
            return results;
        }


        public async Task<List<SelectListItem>> DropdownVehicleBookingDirector()
        {
            var results = new List<SelectListItem>();

            var data = await _rawDataService.GetViewOfficerVehicleBookingDirectorListAsync();
            results = data.OrderBy(x => x.FullName).Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.FullName }).ToList();
            return results;
        }

        public async Task<List<SelectListItem>> DropdownVehicleBookingDirectorByUserId()
        {
            var user = new Appz(MyHttpContext.Current)?.CurrentSignInUser;
            //var results = new List<SelectListItem>();
            //var director = await _rawDataService.GetViewMasterOrganizationAsync(user.Officer.OrganizationId.Value);
            //var data = await _rawDataService.GetViewOfficerVehicleBookingDirectorListAsync();
            //results = data.Where(x => x.OrganizationId == director.Id).OrderBy(x => x.FullName).Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.FullName, Selected=x.Id==director.DirectorId }).ToList();
            //return results;

            var results = new List<SelectListItem>();

            //var listSystemRoel = new List<int> {1 };

            var dataRawOfficer = await _rawDataService.GetViewOfficerListAsync(new VOfficer { Active = true });
            var dataRawRoleAssign = await _rawDataService.GetViewSystemUserRoleAssignListAsync(new VSystemUserRoleAssign());

            var dataOffice = (from o in dataRawOfficer
                              join s in dataRawRoleAssign
                              on o.SystemUserId equals s.SystemUserId
                              where o.Active == true && (s.SystemRoleId == 9 || s.SystemRoleId == 10) && o.OrganizationId == user.Officer.OrganizationId
                              select o);

            results = dataOffice.OrderBy(x => x.FullName).Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.FullName }).ToList();
            return results;

        }

        public async Task<List<SelectListItem>> DropdownFoodCategoryDisplayType()
        {
            var results = new List<SelectListItem>();
            results.Add(new SelectListItem { Value = "1", Text = "อาหารหลัก" });
            results.Add(new SelectListItem { Value = "2", Text = "อาหารว่าง" });
            results.Add(new SelectListItem { Value = "3", Text = "อาหารหลักและอาหารว่าง" });

            return results;
        }

        public async Task<List<SelectListItem>> DropdownMeetingRoom()
        {
            var results = new List<SelectListItem>();
            MeetingRoom sch = new MeetingRoom()
            {
                Active = true,
            };
            var data = await _dataService.GetMeetingRoomListAsync(sch);
            results = data.OrderBy(x => x.Name).Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Name }).ToList();
            return results;
        }

        public async Task<List<SelectListItem>> DropdownMeetingRoomBookingType()
        {
            var results = new List<SelectListItem>();
            MasterBookingType sch = new MasterBookingType()
            {
                Active = true,
            };
            var data = await _masterService.GetMasterBookingTypeListAsync(sch);
            results = data.OrderBy(x => x.Name).Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Name }).ToList();
            return results;
        }

        public async Task<List<SelectListItem>> DropdownBookingStatus()
        {
            var results = new List<SelectListItem>();
            MasterBookingStatus sch = new MasterBookingStatus()
            {
                Active = true,
            };
            var data = await _masterService.GetMasterBookingStatusListAsync(sch);
            results = data.OrderBy(x => x.StatusName).Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.StatusName }).ToList();
            return results;
        }

        public async Task<List<SelectListItem>> DropdownVideoConferenceBookingPriority()
        {
            var results = new List<SelectListItem>();
            MasterVideoConferenceBookingPriority sch = new MasterVideoConferenceBookingPriority()
            {
                Active = true,
            };
            var data = await _masterService.GetMasterVideoConferenceBookingPriorityListAsync(sch);
            results = data.OrderBy(x => x.Id).Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Name }).ToList();
            return results;
        }

        public async Task<List<SelectListItem>> DropdownVideoConferenceLicense()
        {
            var results = new List<SelectListItem>();
            MasterVideoConferenceLicense sch = new MasterVideoConferenceLicense()
            {
                Active = true,
            };
            var data = await _masterService.GetMasterVideoConferenceLicenseListAsync(sch);
            results = data.OrderBy(x => x.Id).Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.LicenseName }).ToList();
            return results;
        }

        public async Task<List<SelectListItem>> DropdownVehicleForAssign(int VehicleBookingId, int? VehicleTypeId = null)
        {
            var results = new List<SelectListItem>();
            
            var res = await _rawDataService.GetSPVehicleForAssignListAsync(VehicleBookingId);
            var data = JsonConvert.DeserializeObject<List<Vehicle>>((string)res.Data);
            if (VehicleTypeId != null)
            {
                data = data.Where(x => x.VehicleTypeId == VehicleTypeId).ToList();
            }

            results = data?.OrderBy(x => x.VehicleRegistration).Select(x => new SelectListItem { Value = x.Id?.ToString() ?? "", Text = x.VehicleRegistration?.ToString()?? "" }).ToList();
            return results;
        }


        public async Task<List<SelectListItem>> DropdownDriverForAssign(int VehicleBookingId)
        {
            var results = new List<SelectListItem>();

            //var res = await _rawDataService.GetSPDriverForAssignListAsync(VehicleBookingId);
            //var data = JsonConvert.DeserializeObject<List<SPDriverForAssign>>((string)res.Data);
            //results = data?.OrderBy(x => x.DriverName).Select(x => new SelectListItem { Value = x.DriverId?.ToString() ?? "", Text = x.DriverName?.ToString() ?? "" }).ToList();

            //var data = await _rawDataService.GetViewOfficerListAsync(new VOfficer { WorkPositionId = 148 , Active = "Y" });
            //var dataAss = await _dataService.AddVehicleBookingAssignAsync
            //if (data.Count() > 0)
            //{
            //    var result = from o in context.V_Officer
            //                 where o.WorkPositionId == 148
            //                 && o.Active == "Y"
            //                 && !context.VehicleBookingAssign.Any(vba => vba.DriverId == o.Id &&
            //                        ((vba.TravelFromDate >= startDateTime && vba.TravelFromDate <= endDateTime) ||
            //                         (vba.TravelToDate >= startDateTime && vba.TravelToDate <= endDateTime)))
            //                 select new
            //                 {
            //                     o.Id,
            //                     o.FullName
            //                 };
           // }
            
            return results;
        }

        public async Task<List<SelectListItem>> DropdownFuelCode()
        {
            var results = new List<SelectListItem>();
            MasterFuelCode sch = new MasterFuelCode()
            {
                Active = true,
            };
            var dataRes = await _masterService.GetMasterFuelCodeListAsync(sch);
            if (dataRes.Type == ApiResultsType.success.ToString())
            {

               var data = JsonConvert.DeserializeObject<List<MasterFuelCode>>((string)dataRes.Data);
                results = data.OrderBy(x => x.Code).Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Code }).ToList();

            }

            return results;
        }


        public async Task<List<SelectListItem>> DropdownBudgetExpenseType(string? IsParent = null)
        {
            var results = new List<SelectListItem>();

            //var sch = new MasterBudgetExpenseType();
            //sch.Active = "Y";

            //if (IsParent != null)
            //{
            //    sch.IsParent = IsParent;
            //}

            //var res = await _masterService.GetMasterBudgetExpenseTypeListAsync(sch);
            //var data = JsonConvert.DeserializeObject<List<MasterBudgetExpenseType>>((string)res.Data);

            //results = data?.OrderBy(x => x.Name).Select(x => new SelectListItem { Value = x.Id?.ToString() ?? "", Text = x.Name?.ToString() ?? "" }).ToList();
            return results;
        }


    }

}
