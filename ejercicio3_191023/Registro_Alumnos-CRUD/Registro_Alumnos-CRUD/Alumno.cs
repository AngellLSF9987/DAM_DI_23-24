﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Registro_Alumnos_CRUD.Clases
{
    public class Alumno
    {
        
            private long codAlum;
            private string cursoAlum;
            private string nomAlum;
            private string apellAlum;
            private long telfAlum;
            private string generoAlum;
            private DateTime fecNacAlum;
            private string mailAlum;

            public long CodAlum
            {
                get { return codAlum; }
                set { codAlum = value; }
            }


            public string CursoAlum
            {
                get { return cursoAlum; }
                set
                {
                    if (value.Length < 1) { throw new Exception("El nombre del curso es demasiado corto"); }
                    else cursoAlum = value.Trim();
                }
            }
            public string NomAlum
            {
                get { return nomAlum; }
                set { nomAlum = value; }

            }
            public string ApellAlum
            {
                get { return apellAlum; }
                set { apellAlum = value; }

            }
            public long TelfAlum
            {
                get { return telfAlum; }
                set { telfAlum = value; }
            }
            public string GeneroAlum
            {
                get { return generoAlum; }
                set { generoAlum = value; }
            }
            public DateTime FecNacAlum
            {
                get { return fecNacAlum; }
                set { fecNacAlum = value; }
            }
            public string MailAlum
            {
                get { return mailAlum; }
                set { mailAlum = value; }

            }
    }
}
