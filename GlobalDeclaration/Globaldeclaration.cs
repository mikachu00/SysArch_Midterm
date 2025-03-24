using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysArch_Midterm.GlobalDeclaration
{
    internal class Globaldeclaration
    {
        public class GlobalDeclarations
        {
            public static OleDbCommand command;
            public static OleDbDataReader reader;
            public static int CollegeID;
            public static int ORNO;
            public static int DepartmentID;
        }
    }
}
