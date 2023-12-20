
using Propriedades.Models;

Pessoa p1 = new Pessoa (nome:"victor", sobrenome: "Nascimento");


Pessoa p2 = new Pessoa(nome:"Junior", sobrenome:"Freitas" );


Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();
