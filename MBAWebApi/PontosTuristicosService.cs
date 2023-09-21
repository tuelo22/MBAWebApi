using System.Collections.Generic;

namespace MBAWebApi
{
    public static class PontosTuristicosService
    {
        public static List<String> Listar()
        {
            return new()
            {
                "Deck de Araçatiba",
                "Praça de Bambui",
                "Praia de Ponta Negra",
                "Farol de Ponta Negra",
                "Praia da Sacristia"
            }; 
        }
    }
}
