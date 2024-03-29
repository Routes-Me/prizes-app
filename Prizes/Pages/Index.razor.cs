﻿using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Prizes.Models;
using Prizes.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prizes.Pages
{

    public partial class Index
    {
        [Parameter]
        public string DrawsId { get; set; }

        CandidatesModel candidatesModel = new CandidatesModel();
        List<Nationalities> nationalitiesList = new List<Nationalities>();
        [Inject]
        protected NationalitiesService nationalitiesService { get; set; }
        [Inject]
        protected CandidateService userService { get; set; }

        private string selectedCulture = System.Threading.Thread.CurrentThread.CurrentCulture.Name;

        string spinner = "d-none", maxDate = string.Empty, minDate = string.Empty;
        string message = string.Empty;
        AlertMessageType messageType = AlertMessageType.Success;
        protected override async Task OnInitializedAsync()
        {
            // await GetNationalities();
            maxDate = DateTime.Now.ToString("yyyy-MM-dd");
            minDate = DateTime.Now.AddYears(-100).ToString("yyyy-MM-dd");
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (selectedCulture == "ar-KW")
            {
                await JSRuntime.InvokeVoidAsync("setRTLAlignment");
            }
            else
            {
                await JSRuntime.InvokeVoidAsync("setLTRAlignment");
            }
        }

        protected async Task GetNationalities()
        {
            var nationalities = await nationalitiesService.GetNationalitiesList();
            nationalitiesList = nationalities;
        }

        public async Task SaveCandidates()
        {
            try
            {
                spinner = string.Empty;
                if (string.IsNullOrEmpty(DrawsId))
                {
                    message = "DrawsId required!!";
                    messageType = AlertMessageType.Error;
                }

                Candidates candidates = new Candidates();
                candidates.Name = candidatesModel.Name;
                candidates.Email = candidatesModel.Email;
                candidates.PhoneNumber = candidatesModel.PhoneNumber;
                candidates.DateOfBirth = Convert.ToDateTime(candidatesModel.DateOfBirth);
                candidates.NationalityId = candidatesModel.NationalityId;

                bool isSuccess = InsertCandidates(candidates, DrawsId);
                if (isSuccess == true)
                {
                    navigationManager.NavigateTo("/success");
                }
                else
                {
                    message = "Registration failed went wrong!! Please try again.";
                    messageType = AlertMessageType.Error;
                }
            }
            catch (Exception)
            {
                message = "Something went wrong!! Please try again.";
                messageType = AlertMessageType.Error;
            }
            spinner = "d-none";
            await Task.Delay(1);
        }

        protected bool InsertCandidates(Candidates candidates, string drawsId)
        {

            return userService.AddCandidates(candidates, drawsId);
        }
    }
}
