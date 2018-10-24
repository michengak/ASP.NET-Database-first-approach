using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ContosoSite.Models
{
    
    
        [MetadataType(typeof(StudentMetadata))]
        public partial class Student
        {
        }

        [MetadataType(typeof(EnrollmentMetadata))]
        public partial class Enrollment
        {
        }
    
}