using Digbyswift.InterviewDec2023.Infrastructure.BuissnessLogic.Model;


namespace Digbyswift.InterviewDec2023.Infrastructure.BusinessLogic.ViewModels
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
            Likes = Concatenate(data.Likes);

        }

        private string Concatenate(string[] likes)
        {
            string content = "";

            int count = 0;

            if (likes == null || likes.Count() == 0)
            {
                return "";
            }
            else
            {
                foreach (string item in likes)
                {
                    if (count == 0)
                    {
                        content += item;
                    }

                    else
                    {
                        content += "," + " " + item;
                    }

                    count++;
                }
            }
            
            return content;
        }
    }
}