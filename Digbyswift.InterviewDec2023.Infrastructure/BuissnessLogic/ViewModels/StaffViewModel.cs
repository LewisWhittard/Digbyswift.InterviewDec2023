using Digbyswift.InterviewDec2023.Infrastructure.BuissnessLogic.Repository;
using System.ComponentModel.DataAnnotations;

namespace Digbyswift.InterviewDec2023.Infrastructure.BuissnessLogic.ViewModels
{

    public class StaffViewModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string JobTitle { get; set; }
        public string Likes { get; set; }

        public StaffViewModel(Staff data)
        {
            Id = data.Id;
            FullName = data.FullName;
            Email = data.Email;
            JobTitle = data.JobTitle;
            Likes = concatenate(data.Likes);

        }

        private string concatenate(string[] likes)
        {
            string Content = "";

            int Count = 0;

            if (likes == null || likes.Count() == 0)
            {
                return "None";
            }
            else
            {
                foreach (string item in likes)
                {
                    if (Count == 0)
                    {
                        Content += item;
                    }

                    else
                    {
                        Content += "," + " " + item;
                    }

                    Count++;
                }
            }
            
            return Content;
        }
    }
}