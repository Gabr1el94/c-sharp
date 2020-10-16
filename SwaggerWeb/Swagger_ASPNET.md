##  Swagger + SQLITE + API - ASP.NET CORE 3
![](https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse3.mm.bing.net%2Fth%3Fid%3DOIP.obQs53j8pdTFD8sgkasHjQHaDt%26pid%3DApi&f=1)

**Pré-requisitos:
**

- Conhecimento lógica, c# e sql;

- Noções básicas terminal e protocolo comunicação HTTP[SOAP, REST, ...];

- Plataforma ASP.NET Core instalado(versão atual);

- Editor VS Code(opcional);

### Tutorial

**1) Abre o terminal e começa criar pasta e entrar na sessão:
**
>  mkdir <Nome_Projeto> && cd <Nome_Projeto>

**2) Inicializar o projeto:
**

>   dotnet new mvc

**3) Abre o vsCode dentro da pasta do projeto:
**
>  code .

**4) Adicionando os pacotes no projeto:**

  **Swagger:**
 >dotnet add package Swashbuckle.AspNetCore -v 5.5.0

**SQLite:**
  >dotnet add package Microsoft.EntityFrameworkCore.Sqlite -v 3.1.9 

**Obs:** *"A extensão "EntityFrameworkCore" pode ser instalado 
outros BDs relacional como SQLSERVER, MYSQL , etc;  "*

**5) Após adicionar os pacotes no projeto vamos implementar:**

- SQLite:
i)Vamos para o arquivo "appsettings.json", no qual iremos adicionar string da conexão do BD SQLite:
```
			// O nome definido do arquivo
			"ConexaoSqlite": {
			"SqliteConnectionString": "Data Source=<NOME_FILE>.db"
			}
```
ii) Agora vamos configurar a classe "Startup.cs" onde vamos inicializar
conexão com o banco pelo método "ConfigureServices":
```
// configuration initialized db by SQLITE
var connection = Configuration["ConexaoSqlite:SqliteConnectionString"];
		services.AddDbContext<MovieContext>(options => 
					options.UseSqlite(connection)
);
```
iii)Crie entidade e context DB para mapear pelo "EntityFrameworkCore" na pasta Model:
```
// Entidade Class Movie
			public class Movie
			{
				public int Id { get; set; }
				public string Nome { get; set; }
				...
			}

			// class ContextDB
			using Microsoft.EntityFrameworkCore;
			
			public class MovieContext: DbContext
			{
			   public MovieContext(DbContextOptions<MovieContext> options) : 
			   base(options)
			   {}
				
				public DbSet<Movie> Movies { get; set; }
				protected override void OnModelCreating(ModelBuilder builder)
				{
					   builder.Entity<Movie>().HasKey(m => m.Id);
					   base.OnModelCreating(builder);
				}
			}
			
```
-  Swagger:
i) Adicione nas classe "Startup.cs" pelo método "ConfigureServices" informações genéricas para sua documentação swagger:
```
           services.AddSwaggerGen(c =>
            {
               c.SwaggerDoc("v1", new OpenApiInfo { 
                            Title = "Swagger Movies Demo", 
                            Version = "v1", 
                            Contact = new OpenApiContact {
                                Name = "SEU_NOME",
                                Email = "seu_email@mail.com",
                                Url = new Uri("SEU_URL")            
                            } 
                });
            });
```
ii)Habilitar Swagger com o nome da requisição Swagger no método "Configure":
```
app.UseSwagger();
app.UseSwaggerUI(c =>{
     c.SwaggerEndpoint("/swagger/v1/swagger.json", "Swagger Movies Demo V1");
});
```
**7) Depois de realizar configurações do Swagger e SQLite, faz o build caso
haja erro ou dependências do projeto;
**
> dotnet build

**8) Start Project;
**
> dotnet run

**Acesso Swagger:** localhost:5000|5001/swagger 

Espero que tenha gostado e bom aproveito! 
