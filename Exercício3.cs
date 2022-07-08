using System;

namespace Módulo2Semana6 {
    internal class Exercício3 {
        List<Aluno> alunos = new List<Aluno>();
        List<Disciplina> disciplinas = new List<Disciplina>();
        List<Nota> notas = new List<Nota>();

        // Adicionando alunos e disciplinas
        alunos.Add(new Aluno("João", "12345"));
            alunos.Add(new Aluno("Maria", "54321"));
            alunos.Add(new Aluno("José", "98765"));
            disciplinas.Add(new Disciplina("Matemática", 3));
            disciplinas.Add(new Disciplina("Português", 2));
            disciplinas.Add(new Disciplina("História", 1));

            // Lançamento de notas
            Console.WriteLine("Digite o nome do aluno: ");
            string nomeAluno = Console.ReadLine();
        Console.WriteLine("Digite o número de chamada do aluno: ");
            string numeroChamada = Console.ReadLine();
        Aluno aluno = new Aluno(nomeAluno, numeroChamada);

        Console.WriteLine("Digite o nome da disciplina: ");
            string nomeDisciplina = Console.ReadLine();
        Console.WriteLine("Digite a quantidade de avaliações: ");
            int quantidadeAvaliacoes = int.Parse(Console.ReadLine());
        Disciplina disciplina = new Disciplina(nomeDisciplina, quantidadeAvaliacoes);

        Console.WriteLine("Digite as notas das avaliações: ");
            string notasAvaliacoes = Console.ReadLine();
        Nota nota = new Nota(notasAvaliacoes);

        // Visualização de boletim
        Console.WriteLine("Nome: " + aluno.Nome);
            Console.WriteLine("Disciplina: " + disciplina.Nome);
            Console.WriteLine("Notas provas: " + nota.Notas);
            Console.WriteLine("Média: " + nota.Media);

            // Exceções
            try {
                if (nota.Media == 0) {
                    throw new Exception("Não existe nenhuma nota lançada.");
    }
} catch (Exception e) {
    Console.WriteLine(e.Message);
}
    }
}
