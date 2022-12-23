using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Learning_DB
{
    public class StoredProcedures
    {
        public static string Loginstudent = "SelectStudent";
        public static string LoginInstructor = "SelectInstructor";
        public static string Loginadmin = "Selectadmin";
        public static string SelectClassroomByCode = "SearchClassroomForStudent";
        public static string EnrollStudentByAccessCode = "EnrollStudentByAccessCode";
        public static string SelectInstructorsForClassByCode = "SelectInstructorsForClassByCode";
        public static string SelectInstructorsForClassByID = "SelectInstructorsForClassByID";
        public static string SelectClassInfoForStudent = "SelectClassroomTitleCourseNameByID";
        public static string SelectClassforInstructorbyID = "SelectClassforInstructorbyID";

        /// Insertion and Update Stored procs
        public static string InsertAdmin = "spInsertAdmin";
        public static string InsertInstructor = "spInsertInstructor";
        public static string UpdateAdmin = "spUpdateAdmin";
        public static string UpdateStudent = "spUpdateStudent";
        public static string UpdateInstructor = "spUpdateInstructor";


        public static string AddClassroom = "spCreateClassroom";

        //Question Stored Procedures 
        public static string AddQuestion = "spAddQuestion";
        public static string AddQuestionOption = "spAddQuestionOption";
        public static string AddQuestionToExam = "spAddQuestionToExam";

        //Material and exam and assignment
        public static string AddMaterial = "spAddNewMaterial";
        public static string AddExam = "spAddExam";
        public static string AddAssignment = "spAddAssignment";




    }
}
