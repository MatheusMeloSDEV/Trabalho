using CLUSA;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;

public class ExportarParaExcel
{
    public void ExportarDadosParaExcel(List<Processo> processos, string caminhoArquivo)
    {
        ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial; // Configuração de licença gratuita

        using (var pacote = new ExcelPackage())
        {
            var planilha = pacote.Workbook.Worksheets.Add("Processos");

            // Cabeçalhos
            planilha.Cells[1, 1].Value = "ID";
            planilha.Cells[1, 2].Value = "Importador";
            planilha.Cells[1, 3].Value = "Produto";
            planilha.Cells[1, 4].Value = "Data Registro LPCO";
            planilha.Cells[1, 5].Value = "Status do Processo";

            // Dados
            for (int i = 0; i < processos.Count; i++)
            {
                var processo = processos[i];
                planilha.Cells[i + 2, 1].Value = processo.Id.ToString();
                planilha.Cells[i + 2, 2].Value = processo.Importador;
                planilha.Cells[i + 2, 3].Value = processo.Produto;
                planilha.Cells[i + 2, 4].Value = processo.DataRegistroLPCO;
                planilha.Cells[i + 2, 5].Value = processo.StatusDoProcesso;
            }

            // Ajuste de largura automática
            planilha.Cells[planilha.Dimension.Address].AutoFitColumns();

            // Salvar arquivo
            File.WriteAllBytes(caminhoArquivo, pacote.GetAsByteArray());
        }
    }
}
