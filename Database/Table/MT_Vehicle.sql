CREATE TABLE [dbo].[MT_Vehicle](
	[VehicleID] [int] IDENTITY(1,1) NOT NULL,
	[Marka] [nvarchar](150) NULL,
	[Model] [nvarchar](150) NULL,
	[PojemnoscSilnika] [nvarchar](150) NULL,
	[VIN] [nvarchar](150) NULL,
	[RokProdukcji] [nvarchar](150) NULL,
	[DataPierwszejRejestracjiWkraju] [nvarchar](150) NULL,
	[NumerRejestracyjny] [nvarchar](150) NULL,
	[OlejSilnikowy] [nvarchar](150) NULL,
	[OlejWprzednimWidelcu] [nvarchar](150) NULL,
	[OlejPrzekladniowy] [nvarchar](150) NULL,
	[PlynHamulocwy] [nvarchar](150) NULL,
	[PlynChlodzacy] [nvarchar](150) NULL,
	[SwieceZaplonowe] [nvarchar](150) NULL,
	[Akumulator] [nvarchar](150) NULL,
	[PlynyEksploatacyjneInne] [nvarchar](150) NULL,
	[PasekNapedowy] [nvarchar](150) NULL,
	[UkladNapedowyInne] [nvarchar](150) NULL,
	[KlientImieNazwisko] [nvarchar](150) NULL,
	[KlientNazwaFirmy] [nvarchar](150) NULL,
	[KlientTelefon] [nvarchar](150) NULL,
	[KlientMiejscowosc] [nvarchar](150) NULL,
	[KlientUlica] [nvarchar](150) NULL,
	[KlientKodPocztowy] [nvarchar](150) NULL,
	[CREDATE] [datetime] NULL,
	[CREUSER] [nvarchar](50) NULL,
	[UPDDATE] [datetime] NULL,
	[UPDUSER] [nvarchar](50) NULL,
 CONSTRAINT [PK_MT_Vehicle] PRIMARY KEY CLUSTERED 
(
	[VehicleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


