USE [master]
GO
/****** Object:  Database [EventosDepG8]    Script Date: 19/09/2021 4:30:26 p. m. ******/
CREATE DATABASE [EventosDepG8]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EventosDepG8', FILENAME = N'C:\Users\User\EventosDepG8.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'EventosDepG8_log', FILENAME = N'C:\Users\User\EventosDepG8_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [EventosDepG8] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EventosDepG8].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EventosDepG8] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EventosDepG8] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EventosDepG8] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EventosDepG8] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EventosDepG8] SET ARITHABORT OFF 
GO
ALTER DATABASE [EventosDepG8] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [EventosDepG8] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EventosDepG8] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EventosDepG8] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EventosDepG8] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EventosDepG8] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EventosDepG8] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EventosDepG8] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EventosDepG8] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EventosDepG8] SET  ENABLE_BROKER 
GO
ALTER DATABASE [EventosDepG8] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EventosDepG8] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EventosDepG8] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EventosDepG8] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EventosDepG8] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EventosDepG8] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [EventosDepG8] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EventosDepG8] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [EventosDepG8] SET  MULTI_USER 
GO
ALTER DATABASE [EventosDepG8] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EventosDepG8] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EventosDepG8] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EventosDepG8] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [EventosDepG8] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [EventosDepG8] SET QUERY_STORE = OFF
GO
USE [EventosDepG8]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [EventosDepG8]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 19/09/2021 4:30:26 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Arbitros]    Script Date: 19/09/2021 4:30:26 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Arbitros](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Identificacion] [nvarchar](max) NULL,
	[Nombre] [nvarchar](max) NULL,
	[Apellidos] [nvarchar](max) NULL,
	[Telefono] [nvarchar](max) NULL,
	[Correo] [nvarchar](max) NULL,
	[Disiplina] [nvarchar](max) NULL,
	[TorneoId] [int] NOT NULL,
	[EscuelaArbitroId] [int] NOT NULL,
 CONSTRAINT [PK_Arbitros] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Canchas]    Script Date: 19/09/2021 4:30:26 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Canchas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](max) NULL,
	[Diciplina] [nvarchar](max) NULL,
	[Estado] [nvarchar](max) NULL,
	[Capacidad] [int] NOT NULL,
	[Medidas] [float] NOT NULL,
	[EscenarioId] [int] NOT NULL,
 CONSTRAINT [PK_Canchas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Deportistas]    Script Date: 19/09/2021 4:30:26 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Deportistas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Documento] [nvarchar](max) NULL,
	[Nombres] [nvarchar](max) NULL,
	[Apelldos] [nvarchar](max) NULL,
	[Genero] [nvarchar](max) NULL,
	[Rh] [nvarchar](max) NULL,
	[EPS] [nvarchar](max) NULL,
	[FechaNacimiento] [datetime2](7) NOT NULL,
	[Disciplina] [nvarchar](max) NULL,
	[Direccion] [nvarchar](max) NULL,
	[NumeroEmergencia] [nvarchar](max) NULL,
	[EquipoId] [int] NOT NULL,
 CONSTRAINT [PK_Deportistas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Entrenadores]    Script Date: 19/09/2021 4:30:26 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Entrenadores](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Documento] [nvarchar](max) NULL,
	[Nombres] [nvarchar](max) NULL,
	[Apellidos] [nvarchar](max) NULL,
	[Genero] [nvarchar](max) NULL,
	[DisciplinaDeportiva] [nvarchar](max) NULL,
	[EquipoId] [int] NOT NULL,
 CONSTRAINT [PK_Entrenadores] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Equipos]    Script Date: 19/09/2021 4:30:26 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Equipos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](max) NULL,
	[CantidadDeportistas] [int] NOT NULL,
	[Disciplina] [nvarchar](max) NULL,
	[PatrocinadorId] [int] NOT NULL,
 CONSTRAINT [PK_Equipos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Escenarios]    Script Date: 19/09/2021 4:30:26 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Escenarios](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](max) NULL,
	[Direccion] [nvarchar](max) NULL,
	[Telefono] [nvarchar](max) NULL,
	[Horario] [nvarchar](max) NULL,
	[TorneoId] [int] NOT NULL,
 CONSTRAINT [PK_Escenarios] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EscuelaArbitros]    Script Date: 19/09/2021 4:30:26 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EscuelaArbitros](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nit] [nvarchar](max) NULL,
	[Nombre] [nvarchar](max) NULL,
	[Resolucion] [nvarchar](max) NULL,
	[Direccion] [nvarchar](max) NULL,
	[Telefono] [nvarchar](max) NULL,
	[Correo] [nvarchar](max) NULL,
 CONSTRAINT [PK_EscuelaArbitros] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Municipios]    Script Date: 19/09/2021 4:30:26 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Municipios](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](max) NULL,
 CONSTRAINT [PK_Municipios] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patrocinadores]    Script Date: 19/09/2021 4:30:26 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patrocinadores](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Identificacion] [nvarchar](max) NULL,
	[Nombre] [nvarchar](max) NULL,
	[TipoPersona] [nvarchar](max) NULL,
	[Direccion] [nvarchar](max) NULL,
	[Telefono] [nvarchar](max) NULL,
 CONSTRAINT [PK_Patrocinadores] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TorneoEquipos]    Script Date: 19/09/2021 4:30:26 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TorneoEquipos](
	[TorneoId] [int] NOT NULL,
	[EquipoId] [int] NOT NULL,
 CONSTRAINT [PK_TorneoEquipos] PRIMARY KEY CLUSTERED 
(
	[EquipoId] ASC,
	[TorneoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Torneos]    Script Date: 19/09/2021 4:30:26 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Torneos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](max) NULL,
	[Categoria] [nvarchar](max) NULL,
	[FechaInicial] [datetime2](7) NOT NULL,
	[FechaFinal] [datetime2](7) NOT NULL,
	[Tipo] [nvarchar](max) NULL,
	[MunicipioId] [int] NOT NULL,
 CONSTRAINT [PK_Torneos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Index [IX_Arbitros_EscuelaArbitroId]    Script Date: 19/09/2021 4:30:26 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_Arbitros_EscuelaArbitroId] ON [dbo].[Arbitros]
(
	[EscuelaArbitroId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Arbitros_TorneoId]    Script Date: 19/09/2021 4:30:26 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_Arbitros_TorneoId] ON [dbo].[Arbitros]
(
	[TorneoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Deportistas_EquipoId]    Script Date: 19/09/2021 4:30:26 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_Deportistas_EquipoId] ON [dbo].[Deportistas]
(
	[EquipoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Entrenadores_EquipoId]    Script Date: 19/09/2021 4:30:26 p. m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Entrenadores_EquipoId] ON [dbo].[Entrenadores]
(
	[EquipoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Equipos_PatrocinadorId]    Script Date: 19/09/2021 4:30:26 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_Equipos_PatrocinadorId] ON [dbo].[Equipos]
(
	[PatrocinadorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Escenarios_TorneoId]    Script Date: 19/09/2021 4:30:26 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_Escenarios_TorneoId] ON [dbo].[Escenarios]
(
	[TorneoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_TorneoEquipos_TorneoId]    Script Date: 19/09/2021 4:30:26 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_TorneoEquipos_TorneoId] ON [dbo].[TorneoEquipos]
(
	[TorneoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Torneos_MunicipioId]    Script Date: 19/09/2021 4:30:26 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_Torneos_MunicipioId] ON [dbo].[Torneos]
(
	[MunicipioId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Arbitros]  WITH CHECK ADD  CONSTRAINT [FK_Arbitros_EscuelaArbitros_EscuelaArbitroId] FOREIGN KEY([EscuelaArbitroId])
REFERENCES [dbo].[EscuelaArbitros] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Arbitros] CHECK CONSTRAINT [FK_Arbitros_EscuelaArbitros_EscuelaArbitroId]
GO
ALTER TABLE [dbo].[Arbitros]  WITH CHECK ADD  CONSTRAINT [FK_Arbitros_Torneos_TorneoId] FOREIGN KEY([TorneoId])
REFERENCES [dbo].[Torneos] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Arbitros] CHECK CONSTRAINT [FK_Arbitros_Torneos_TorneoId]
GO
ALTER TABLE [dbo].[Deportistas]  WITH CHECK ADD  CONSTRAINT [FK_Deportistas_Equipos_EquipoId] FOREIGN KEY([EquipoId])
REFERENCES [dbo].[Equipos] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Deportistas] CHECK CONSTRAINT [FK_Deportistas_Equipos_EquipoId]
GO
ALTER TABLE [dbo].[Entrenadores]  WITH CHECK ADD  CONSTRAINT [FK_Entrenadores_Equipos_EquipoId] FOREIGN KEY([EquipoId])
REFERENCES [dbo].[Equipos] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Entrenadores] CHECK CONSTRAINT [FK_Entrenadores_Equipos_EquipoId]
GO
ALTER TABLE [dbo].[Equipos]  WITH CHECK ADD  CONSTRAINT [FK_Equipos_Patrocinadores_PatrocinadorId] FOREIGN KEY([PatrocinadorId])
REFERENCES [dbo].[Patrocinadores] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Equipos] CHECK CONSTRAINT [FK_Equipos_Patrocinadores_PatrocinadorId]
GO
ALTER TABLE [dbo].[Escenarios]  WITH CHECK ADD  CONSTRAINT [FK_Escenarios_Torneos_TorneoId] FOREIGN KEY([TorneoId])
REFERENCES [dbo].[Torneos] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Escenarios] CHECK CONSTRAINT [FK_Escenarios_Torneos_TorneoId]
GO
ALTER TABLE [dbo].[TorneoEquipos]  WITH CHECK ADD  CONSTRAINT [FK_TorneoEquipos_Equipos_EquipoId] FOREIGN KEY([EquipoId])
REFERENCES [dbo].[Equipos] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TorneoEquipos] CHECK CONSTRAINT [FK_TorneoEquipos_Equipos_EquipoId]
GO
ALTER TABLE [dbo].[TorneoEquipos]  WITH CHECK ADD  CONSTRAINT [FK_TorneoEquipos_Torneos_TorneoId] FOREIGN KEY([TorneoId])
REFERENCES [dbo].[Torneos] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TorneoEquipos] CHECK CONSTRAINT [FK_TorneoEquipos_Torneos_TorneoId]
GO
ALTER TABLE [dbo].[Torneos]  WITH CHECK ADD  CONSTRAINT [FK_Torneos_Municipios_MunicipioId] FOREIGN KEY([MunicipioId])
REFERENCES [dbo].[Municipios] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Torneos] CHECK CONSTRAINT [FK_Torneos_Municipios_MunicipioId]
GO
USE [master]
GO
ALTER DATABASE [EventosDepG8] SET  READ_WRITE 
GO
