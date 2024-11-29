class DictionaryAlura {
    public static void Main(String[] args) {

        
        //NOME / DISCIPLINA / NOTAS
        var notasAlunosDisciplina = new Dictionary<string, Dictionary<string, List<int>>> 
        {
            
            { 
            "Ana", new Dictionary<string, List<int>>
                {
                    {"C#", new List<int>{ 10,8,10 } },
                    {"JAVA", new List<int> { 8,10,7} },
                    {"SQL", new List<int>{ 6,8,10} }
                }

            },

            { 
            "Bob", new Dictionary<string, List<int>>
                {
                    {"C#", new List<int>{ 10,10,10 } },
                    {"JAVA", new List<int> { 9,10,8} },
                    {"SQL", new List<int>{ 10,10,10} }
                }
            }

        };

        foreach (var aluno in notasAlunosDisciplina)
        {
            Console.WriteLine("{ "+$"Aluno: {aluno.Key}");

            foreach (var disciplina in aluno.Value) 
            {
                Console.WriteLine($"\t> Disciplina: {disciplina.Key}");
                Console.WriteLine($"\t\tNotas: {string.Join(", ", disciplina.Value)}");

                double somaDisciplina = disciplina.Value.Sum();
                double mediaDisciplina = somaDisciplina / disciplina.Value.Count;
                Console.WriteLine($"\t\tA média de {aluno.Key} em {disciplina.Key} é: {mediaDisciplina:F2}");
            }

            Console.WriteLine("}\n");
        }

    }
}