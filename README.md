# Conversor de PDF para JPG

Este projeto é uma aplicação de console em C# que converte todas as páginas de arquivos PDF em imagens JPG e salva em um diretório especificado. Ele utiliza a biblioteca Spire.Pdf para realizar a conversão.

## Funcionalidades

- Listar todos os arquivos PDF em um diretório de entrada.
- Converter cada página de cada PDF para uma imagem JPG.
- Salvar as imagens JPG resultantes em um diretório de saída.

## Requisitos

- [.NET 5.0 ou superior](https://dotnet.microsoft.com/download)
- Biblioteca [Spire.Pdf](https://www.e-iceblue.com/Introduce/pdf-for-net-introduce.html)

## Instalação

1. Clone este repositório:
    ```sh
    git clone https://github.com/seu-usuario/conversor-pdf-jpg.git
    cd conversor-pdf-jpg
    ```

2. Abra o projeto no seu IDE favorito (Visual Studio, Visual Studio Code, etc.).

3. Instale a biblioteca Spire.Pdf através do NuGet:
    ```sh
    dotnet add package Spire.PDF
    ```

## Uso

1. Configure os caminhos de entrada e saída no código:
    ```csharp
    string caminhoPDFs = @"C:\Caminho\Para\Pasta\Com\Pdfs";
    string saidaImagens = @"C:\Caminho\Para\Pasta\De\Saida";
    ```

2. Execute a aplicação:
    ```sh
    dotnet run
    ```
