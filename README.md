# Gerador de Frase

## Descrição
Este é um projeto em C# desenvolvido no Visual Studio utilizando Windows Forms. O aplicativo consome uma API para obter frases aleatórias e exibi-las em uma interface gráfica. A aplicação utiliza a biblioteca `Newtonsoft.Json` para processar os dados recebidos da API e a classe `WebClient` para realizar requisições HTTP.

## Funcionalidades
- Geração de frases aleatórias ao clicar em um botão.
- Exibição da frase em um controle `Label` na interface gráfica.
- Tratamento de erros com exibição de mensagem caso a frase não seja obtida.

## Pré-requisitos
- **Visual Studio** (versão recomendada: 2019 ou superior)
- **.NET Framework** (versão compatível com o projeto, ex.: 4.7.2 ou superior)
- Pacote NuGet: `Newtonsoft.Json`
- Conexão com a internet para acessar a API `https://estevaorada.com/aulas/api/frases/`

## Como instalar
1. Clone ou baixe o repositório do projeto.
2. Abra o projeto no Visual Studio.
3. Instale o pacote `Newtonsoft.Json` via NuGet Package Manager:
   - No Visual Studio, vá em `Tools > NuGet Package Manager > Manage NuGet Packages for Solution`.
   - Procure por `Newtonsoft.Json` e instale a versão mais recente.
4. Compile e execute o projeto.

## Estrutura do Projeto
- **Form1.cs**: Contém a lógica principal do aplicativo, incluindo a interface gráfica e a chamada à API.
- **Frase.cs** (não mostrado no código fornecido, mas presumido): Classe modelo para desserializar a resposta JSON da API.
- **Form1.Designer.cs**: Arquivo gerado automaticamente pelo Visual Studio para a interface gráfica.

## Como usar
1. Execute o aplicativo no Visual Studio (pressione `F5` ou clique em "Start").
2. Na janela que abrir, clique no botão "Gerar Frase".
3. A frase obtida da API será exibida no campo `lblResultado`.
4. Caso ocorra um erro (como falha na conexão com a API), uma mensagem será exibida.

## Código Principal
O código principal está no evento `btnGerarFrase_Click` do arquivo `Form1.cs`. Ele faz o seguinte:
- Faz uma requisição HTTP para a URL `https://estevaorada.com/aulas/api/frases/` usando `WebClient`.
- Converte a resposta para UTF-8 para corrigir problemas de acentuação.
- Desserializa o JSON recebido em um objeto da classe `Frase` usando `Newtonsoft.Json`.
- Exibe a frase no controle `lblResultado` ou mostra uma mensagem de erro caso a frase não seja obtida.

## Exemplo de Uso do Código
```csharp
private void btnGerarFrase_Click(object sender, EventArgs e)
{
    string url = $"https://estevaorada.com/aulas/api/frases/";
    Frase frase = new Frase();

    using (WebClient navegador = new WebClient())
    {
        string conteudo = navegador.DownloadString(url);
        conteudo = Encoding.UTF8.GetString(Encoding.Default.GetBytes(conteudo));
        frase = JsonConvert.DeserializeObject<Frase>(conteudo);

        if (!string.IsNullOrEmpty(frase.Frase_))
        {
            lblResultado.Text = frase.Frase_;
        }
        else
        {
            MessageBox.Show("Não foi possível obter a frase!");
        }
    }
}
```

## Notas
- Certifique-se de que a API `https://estevaorada.com/aulas/api/frases/` esteja acessível e retornando dados no formato JSON esperado.
- A classe `Frase` deve ter uma propriedade `Frase_` para corresponder ao JSON retornado pela API.
- O projeto utiliza Windows Forms, que é ideal para aplicações desktop simples com interface gráfica.

## Possíveis Melhorias
- Adicionar tratamento de erros mais robusto para falhas de rede.
- Implementar um mecanismo de cache para frases já obtidas.
- Melhorar a interface gráfica com mais controles ou estilos.

## Licença
Este projeto é apenas para fins educacionais. Não possui uma licença específica.