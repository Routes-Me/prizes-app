using Microsoft.AspNetCore.Components;
using PrizesService.Models;
using PrizesService.Models.ResponseModel;
using PrizesService.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrizesService.Pages
{

    public partial class Index : ComponentBase
    {

        UsersModel model = new UsersModel();
        List<NationalitiesModel> nationalitiesModel = new List<NationalitiesModel>();
        [Inject]
        protected NationalitiesService nationalitiesService { get; set; }
        [Inject]
        protected UserService userService { get; set; }

        string spinner = "d-none";
        string message = string.Empty;
        AlertMessageType messageType = AlertMessageType.Success;
        protected override async Task OnInitializedAsync()
        {
            await GetNationalities();
        }

        protected async Task GetNationalities()
        {
            var nationalities = await nationalitiesService.GetNationalitiesList();
            nationalitiesModel = nationalities;
        }

        public async Task RegisterUser()
        {
            navigationManager.NavigateTo("/success");
            //try
            //{
            //    spinner = string.Empty;
            //    UsersModel usersModel = new UsersModel();
            //    usersModel.Name = model.Name;
            //    usersModel.Email = model.Email;
            //    usersModel.PhoneNumber = model.PhoneNumber;
            //    usersModel.DateOfBirth = model.DateOfBirth;
            //    usersModel.NationalityId = model.NationalityId;
            //    await InsertUsers(usersModel);
            //}
            //catch (Exception)
            //{
            //    message = "Something went wrong!! Please try again.";
            //    messageType = AlertMessageType.Error;
            //}
            //spinner = "d-none";
            //await Task.Delay(1);
        }

        protected async Task InsertUsers(UsersModel usersModel)
        {
            await userService.AddUsers(usersModel);
        }
    }
}
