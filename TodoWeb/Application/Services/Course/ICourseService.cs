﻿using TodoWeb.Application.Dtos.CourseModel;
using TodoWeb.Application.Dtos.CourseStudentDetailModel;

namespace TodoWeb.Application.Services.Course
{
    public interface ICourseService
    {
        public IEnumerable<CourseViewModel> GetCourses(int? courseId);

        public IEnumerable<CourseStudentDetailViewModel> GetCoursesDetail(int? courseId);

        public int Post(PostCourseViewModel course);
        public int Put(CourseViewModel course);
        public int Delete(int courseId);
    }
}
