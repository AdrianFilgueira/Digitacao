CREATE TRIGGER salvaLicao
	ON [dbo].[aluno]
	AFTER UPDATE
	AS
	BEGIN
            SET NOCOUNT ON
			
	INSERT INTO aula (aluno, licao, licaoFeitaEm, aproveitamento, tempoDecorrido, erros, toques, feita) 
	SELECT nome, licao, licaoFeitaEm, aproveitamento, tempoDecorrido, erros, toques, feita FROM inserted
	END
