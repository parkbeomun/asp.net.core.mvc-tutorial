# ASP.NET MVC Tutorial
https://docs.microsoft.com/ko-kr/aspnet/core/tutorials/razor-pages/?view=aspnetcore-5.0

### OS : macOS
### TOOL : Visual Studio or Jenbrain Rider

### Download .NET SDK
https://dotnet.microsoft.com/download#macos

### install dotnet tool 

### .net cli dotent-ef , codegenerator tool 설치
```
dotnet tool install --global dotnet-ef
dotnet tool install --global dotent-aspnet-codegenerator
```

### code generator
```
dotnet-aspnet-codegenerator controller -name MoviesController -m Movie -dc MvcMovieContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries -sqlite
```


### App Run
```
dot build 
dotnet run 
```

## MVC

MVC 아키텍처 패턴은 Model View Controller 패턴을 통해 기존 모놀리식 응용 프로그램보다 쉽게 테스트하고 업데이트할 수 있는 앱을 만들 수 있다. 


## EF Core

EF(Entity Framework) Core 는 Entity Framework 데이터 엑세스 기술의 가볍고 확장 가능한 오픈소스 플랫폼 교차 버전이다.

* .NET 개발자가 .NET 개체를 사용하여 데이터베이스로 작업할 수 있도록 한다.
* 개발자가 일반적으로 작성해야 하는 데이터 엑세스 코드가 필요하지 않다. 
* 오라클 9i 를 지원하는지 확인 필요