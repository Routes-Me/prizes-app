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
            var country = new List<string>()
                    {

"Afghanistan						",
"Albania							",
"Algeria							",
"Andorra                    		",
"Angola                     		",
"Antigua and Barbuda        		",
"Argentina                  		",
"Armenia                    		",
"Australia                  		",
"Austria                    		",
"Azerbaijan                 		",
"Bahamas                    		",
"Bahrain                    		",
"Bangladesh                 		",
"Barbados                   		",
"Belarus                    		",
"Belgium                    		",
"Belize                     		",
"Benin                      		",
"Bhutan                     		",
"Bolivia                    		",
"Bosnia and Herzegovina     		",
"Botswana                   		",
"Brazil                     		",
"Brunei                     		",
"Bulgaria                   		",
"Burkina Faso               		",
"Burundi                    		",
"Côte d'Ivoire              		",
"Cabo Verde                 		",
"Cambodia                   		",
"Cameroon                   		",
"Canada                     		",
"Central African Republic   		",
"Chad                       		",
"Chile                      		",
"China                      		",
"Colombia                   		",
"Comoros                    		",
"Congo (Congo-Brazzaville)  		",
"Costa Rica                 		",
"Croatia                    		",
"Cuba                       		",
"Cyprus                     		",
"Czechia (Czech Republic)   		",
"Democratic Republic of the Congo,  ",
"Denmark                     		",
"Djibouti                    		",
"Dominica                    		",
"Dominican Republic          		",
"Ecuador                     		",
"Egypt                       		",
"El Salvador                 		",
"Equatorial Guinea           		",
"Eritrea                     		",
"Estonia                     		",
"Eswatini  		",
"Ethiopia                    		",
"Fiji                        		",
"Finland                     		",
"France                      		",
"Gabon                       		",
"Gambia                      		",
"Georgia                     		",
"Germany                     		",
"Ghana                       		",
"Greece                      		",
"Grenada                     		",
"Guatemala                   		",
"Guinea                      		",
"Guinea-Bissau               		",
"Guyana                      		",
"Haiti                       		",
"Holy See                    		",
"Honduras                    		",
"Hungary                     		",
"Iceland                     		",
"India                       		",
"Indonesia                   		",
"Iran                        		",
"Iraq                        		",
"Ireland                     		",
"Israel                      		",
"Italy                       		",
"Jamaica                     		",
"Japan                       		",
"Jordan                      		",
"Kazakhstan                  		",
"Kenya                       		",
"Kiribati                    		",
"Kuwait                      		",
"Kyrgyzstan                  		",
"Laos                        		",
"Latvia                      		",
"Lebanon                     		",
"Lesotho                     		",
"Liberia                     		",
"Libya                       		",
"Liechtenstein               		",
"Lithuania                   		",
"Luxembourg                  		",
"Madagascar                  		",
"Malawi                      		",
"Malaysia                    		",
"Maldives                    		",
"Mali                        		",
"Malta                       		",
"Marshall Islands            		",
"Mauritania                  		",
"Mauritius                   		",
"Mexico                      		",
"Micronesia                  		",
"Moldova                     		",
"Monaco                      		",
"Mongolia                    		",
"Montenegro                  		",
"Morocco                     		",
"Mozambique                  		",
"Myanmar (formerly Burma)    		",
"Namibia                     		",
"Nauru                       		",
"Nepal                       		",
"Netherlands                 		",
"New Zealand                 		",
"Nicaragua                   		",
"Niger                       		",
"Nigeria                     		",
"North Korea                 		",
"North Macedonia             		",
"Norway                      		",
"Oman                        		",
"Pakistan                    		",
"Palau                       		",
"Palestine State             		",
"Panama                      		",
"Papua New Guinea            		",
"Paraguay                    		",
"Peru                        		",
"Philippines                 		",
"Poland                      		",
"Portugal                    		",
"Qatar                       		",
"Romania                     		",
"Russia                      		",
"Rwanda                      		",
"Saint Kitts and Nevis       		",
"Saint Lucia                 		",
"Saint Vincent and the Grenadines	",
"Samoa								",
"San Marino                         ",
"Sao Tome and Principe              ",
"Saudi Arabia                       ",
"Senegal                            ",
"Serbia                             ",
"Seychelles                         ",
"Sierra Leone                       ",
"Singapore                          ",
"Slovakia                           ",
"Slovenia,                          ",
"Solomon Islands                    ",
"Somalia                            ",
"South Africa                       ",
"South Korea                        ",
"South Sudan                        ",
"Spain                              ",
"Sri Lanka                          ",
"Sudan                              ",
"Suriname                           ",
"Sweden                             ",
"Switzerland                        ",
"Syria                              ",
"Tajikistan                         ",
"Tanzania                           ",
"Thailand                           ",
"Timor-Leste                        ",
"Togo                               ",
"Tonga                              ",
"Trinidad and Tobago                ",
"Tunisia                            ",
"Turkey                             ",
"Turkmenistan                       ",
"Tuvalu                             ",
"Uganda                             ",
"Ukraine                            ",
"United Arab Emirates               ",
"United Kingdom                     ",
"United States of America           ",
"Uruguay                            ",
"Uzbekistan                         ",
"Vanuatu                            ",
"Venezuela                          ",
"Vietnam                            ",
"Yemen                              ",
"Zambia                             ",
"Zimbabwe"                                             

                    };
            int i = 0;
            foreach (var item in country)
            {
                i++;
                NationalitiesModel data = new NationalitiesModel();
                data.NationalityId = i;
                data.Name = item;
                nationalitiesModel.Add(data);
            }

            //var nationalities = await nationalitiesService.GetNationalitiesList();
            //nationalitiesModel = nationalities;
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
