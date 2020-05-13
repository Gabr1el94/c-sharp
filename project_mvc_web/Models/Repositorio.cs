using System;
using System.Collections.Generic;

namespace project_mvc_web.Models
{
    public class Repositorio
    {
        private static List<Convidados> LISTA = new List<Convidados>();

        public static void adicionarResposta(Convidados resposta){
            LISTA.Add(resposta);
        }

        public static IEnumerable<Convidados> listarFinal{
            get{
                return LISTA;
            }
        }
    }
}