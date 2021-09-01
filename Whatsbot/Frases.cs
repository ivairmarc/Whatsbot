using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWritesvFile
{
    public class Frases
    {
        //int es = 0;
        // int ln = 0;
        private static string _resposta;
        public static string Resposta
        {
            get { return _resposta; }
            set { _resposta = value; }
        }

        private static int _nu1;
        public static int Nu1
        {
            get { return _nu1; }
            set { _nu1 = value; }
        }

        // numero dos files de mensagem
        private static int _nu;
        public static int Nu
        {
            get { return _nu; }
            set { _nu = value; }
        }
        public static string[] ContMidia = new string[30];
        private static int _es;
        public static int Es
        {
            get { return _es; }
            set { _es = value; }
        }

        private static int _ln;
        public static int Ln
        {
            get { return _ln; }
            set { _ln = value; }
        }
        private static int _lnBody;
        public static int LnBody
        {
            get { return _lnBody; }
            set { _lnBody = value; }

        }

        private static int _delay;
        public static int Delay
        {
            get { return _delay; }
            set { _delay = value; }

        }
        private static int _midia;
        public static int Midia
        {
            get { return _midia; }
            set { _midia = value; }
        }
        private static int _respCli;
        public static int RespCli
        {
            get { return _respCli; }
            set { _respCli = value; }
        }
        private static string _cpf;
        public static string Cpf
        {
            get { return _cpf; }
            set { _cpf = value; }
        }

        private static string _vlrSaqueMax;
        public static string VlrSaqueMax { get { return _vlrSaqueMax; } set { _vlrSaqueMax = value; } }

        private static string _vlrsaqueMin;
        public static string VlrSaqueMin { get { return _vlrsaqueMin; } set { _vlrsaqueMin = value; } }

        private static string _nome;
        public static string Nome { get { return _nome; } set { _nome = value; } }

        private static string _nomecompleto;
        public static string NomeCompleto { get { return _nomecompleto; } set { _nomecompleto = value; } }

        private static string _celular;
        public static string Celular
        {
            get { return _celular; }
            set { _celular = value; }
        }
    }
}
