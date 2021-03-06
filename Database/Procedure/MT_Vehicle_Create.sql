CREATE PROCEDURE [dbo].[MT_Vehicle_Create](
	@VehicleID int = null,
    @Marka nvarchar(150) = null,
	@Model nvarchar(150) = null,
	@PojemnoscSilnika nvarchar(150) = null,
	@VIN nvarchar(150) = null,
	@RokProdukcji nvarchar(150) = null,
	@DataPierwszejRejestracjiWkraju nvarchar(150) = null,
	@NumerRejestracyjny nvarchar(150) = null,
	@OlejSilnikowy nvarchar(150) = null,
	@OlejWprzednimWidelcu nvarchar(150) = null,
	@OlejPrzekladniowy nvarchar(150) = null,
	@PlynHamulocwy nvarchar(150) = null,
	@PlynChlodzacy nvarchar(150) = null,
	@SwieceZaplonowe nvarchar(150) = null,
	@Akumulator nvarchar(150) = null,
	@PlynyEksploatacyjneInne nvarchar(150) = null,
	@PasekNapedowy nvarchar(150) = null,
	@UkladNapedowyInne nvarchar(150) = null,
	@KlientImieNazwisko nvarchar(150) = null,
	@KlientNazwaFirmy nvarchar(150) = null,
	@KlientTelefon nvarchar(150) = null,
	@KlientMiejscowosc nvarchar(150) = null,
	@KlientUlica nvarchar(150) = null,
	@KlientKodPocztowy nvarchar(150) = null,
    @CREDATE datetime = null,
    @CREUSER nvarchar(50) = null
)
--WITH ENCRYPTION
AS


IF NOT EXISTS (SELECT * FROM MT_Vehicle WHERE VehicleID = @VehicleID)
BEGIN
    INSERT INTO MT_Vehicle(Marka, Model, PojemnoscSilnika, VIN, RokProdukcji, DataPierwszejRejestracjiWkraju, NumerRejestracyjny, OlejSilnikowy, OlejWprzednimWidelcu, OlejPrzekladniowy, PlynHamulocwy, PlynChlodzacy, SwieceZaplonowe, Akumulator, PlynyEksploatacyjneInne, PasekNapedowy, UkladNapedowyInne, KlientImieNazwisko, KlientNazwaFirmy, KlientTelefon, KlientMiejscowosc, KlientUlica, KlientKodPocztowy, CREDATE, CREUSER)
    VALUES (@Marka, @Model, @PojemnoscSilnika, @VIN, @RokProdukcji, @DataPierwszejRejestracjiWkraju, @NumerRejestracyjny, @OlejSilnikowy, @OlejWprzednimWidelcu, @OlejPrzekladniowy, @PlynHamulocwy, @PlynChlodzacy, @SwieceZaplonowe, @Akumulator, @PlynyEksploatacyjneInne, @PasekNapedowy, @UkladNapedowyInne, @KlientImieNazwisko, @KlientNazwaFirmy, @KlientTelefon, @KlientMiejscowosc, @KlientUlica, @KlientKodPocztowy, @CREDATE, @CREUSER)
END
ELSE
BEGIN
    UPDATE MT_Vehicle SET
        Marka = @Marka, 
		Model = @Model, 
		PojemnoscSilnika = @PojemnoscSilnika, 
		VIN = @VIN, 
		RokProdukcji = @RokProdukcji, 
		DataPierwszejRejestracjiWkraju = @DataPierwszejRejestracjiWkraju, 
		NumerRejestracyjny = @NumerRejestracyjny, 
		OlejSilnikowy = @OlejSilnikowy, 
		OlejWprzednimWidelcu = @OlejWprzednimWidelcu, 
		OlejPrzekladniowy = @OlejPrzekladniowy, 
		PlynHamulocwy = @PlynHamulocwy, 
		PlynChlodzacy = @PlynChlodzacy, 
		SwieceZaplonowe = @SwieceZaplonowe, 
		Akumulator = @Akumulator, 
		PlynyEksploatacyjneInne = @PlynyEksploatacyjneInne, 
		PasekNapedowy = @PasekNapedowy, 
		UkladNapedowyInne = @UkladNapedowyInne, 
		KlientImieNazwisko = @KlientImieNazwisko,
		KlientNazwaFirmy = @KlientNazwaFirmy, 
		KlientTelefon = @KlientTelefon, 
		KlientMiejscowosc = @KlientMiejscowosc, 
		KlientUlica = @KlientUlica, 
		KlientKodPocztowy = @KlientKodPocztowy, 
		CREDATE = @CREDATE, 
		CREUSER = @CREUSER
        WHERE VehicleID = @VehicleID
END

