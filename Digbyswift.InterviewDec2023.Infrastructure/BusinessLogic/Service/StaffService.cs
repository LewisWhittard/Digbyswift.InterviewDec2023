﻿using Digbyswift.InterviewDec2023.Infrastructure.BuissnessLogic.Repository;
using Digbyswift.InterviewDec2023.Infrastructure.BuissnessLogic.Model;


namespace Digbyswift.InterviewDec2023.Infrastructure.BuissnessLogic.Service
{
    public class StaffService
    {
        private static StaffRepositoryJson _staffRepository { get; set; }

        public StaffService()
        {
            _staffRepository = new StaffRepositoryJson();
        }

        public List<Staff> GetAllStaff()
        {
            return _staffRepository.GetAllStaff().ToList();
        }

        public Staff GetStaffById(int id) 
        {
            return _staffRepository.Get(id);
        }
    }
}