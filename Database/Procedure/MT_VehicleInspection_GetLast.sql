CREATE PROCEDURE [dbo].[MT_VehicleInspection_GetLast]
AS

    SELECT TOP 5
		ve.VIN,
		ve.Marka,
		ve.Model,
	   vi.InspectionID
      ,vi.VehicleID
	  ,vi.OlejSilnikowyInspekcja 
      ,vi.OlejSilnikowyWymianaTak 
      ,vi.OlejSilnikowyWymianaNie 
      ,vi.FiltrOlejuInspekcja 
      ,vi.FiltrOlejuWymianaTak 
      ,vi.FiltrOlejuWymianaNie 
      ,vi.FiltrPowietrzaInspekcja 
      ,vi.FiltrPowietrzaWymianaTak 
      ,vi.FiltrPowietrzaWymianaNie 
      ,vi.FiltrPaliwaInspekcja 
      ,vi.FiltrPaliwaWymianaTak 
      ,vi.FiltrPaliwaWymianaNie 
      ,vi.KlockiSzczekiHamulcowePrzodInspekcja 
      ,vi.KlockiSzczekiHamulcowePrzodWymianaTak 
      ,vi.KlockiSzczekiHamulcowePrzodWymianaNie 
      ,vi.KlockiSzczekiHamulcoweTylInspekcja 
      ,vi.KlockiSzczekiHamulcoweTylWymianaTak 
      ,vi.KlockiSzczekiHamulcoweTyl2WymianaNie 
      ,vi.PlynHamulcowyInspekcja 
      ,vi.PlynHamulcowyWymianaTak 
      ,vi.PlynHamulcowyWymianaNie 
      ,vi.SwieceZaplonoweInspekcja 
      ,vi.SwieceZaplonoweWymianaTak 
      ,vi.SwieceZaplonowe2WymianaNie 
      ,vi.FajkiZaplonoweInspekcja 
      ,vi.FajkiZaplonoweWymianaTak 
      ,vi.FajkiZaplonoweWymianaNie 
      ,vi.PrzewodyWysNapieciaInspekcja 
      ,vi.PrzewodyWysNapieciaWymianaTak 
      ,vi.PrzewodyWysNapieciaWymianaNie 
      ,vi.PlynChlodzacyInspekcja 
      ,vi.PlynChlodzacyWymianaTak 
      ,vi.PlynChlodzacyWymianaNie 
      ,vi.OlejWprzednimZawieszeniuInspekcja 
      ,vi.OlejWprzednimZawieszeniuWymianaTak 
      ,vi.OlejWprzednimZawieszeniuWymianaNie 
      ,vi.UszczelniaczePrzedniegoZawieszeniaInspekcja 
      ,vi.UszczelniaczePrzedniegoZawieszeniaWymianaTak 
      ,vi.UszczelniaczePrzedniegoZawieszeniaWymianaNie 
      ,vi.ZestawNapedowyInspekcja 
      ,vi.ZestawNapedowyWymianaTak 
      ,vi.ZestawNapedowyWymianaNie 
      ,vi.ZaworyInspekcja 
      ,vi.ZaworyWymianaTak 
      ,vi.ZaworyWymianaNie 
      ,vi.LancuchNapinaczRozrzaduInspekcja 
      ,vi.LancuchNapinaczRozrzaduWymianaTak 
      ,vi.LancuchNapinaczRozrzaduWymianaNie 
      ,vi.LinkaGazuInspekcja 
      ,vi.LinkaGazuWymianaTak 
      ,vi.LinkaGazuWymianaNie 
      ,vi.LinkaSpedzeglaInspekcja 
      ,vi.LinkaSpedzeglaWymianaTak 
      ,vi.LinkaSpedzeglaWymianaNie 
      ,vi.LinkaHamulcaPrzodInspekcja 
      ,vi.LinkaHamulcaPrzodWymianaTak 
      ,vi.LinkaHamulcaPrzodWymianaNie 
      ,vi.LinkaHamulcaTylInspekcja 
      ,vi.LinkaHamulcaTylWymianaTak 
      ,vi.LinkaHamulcaTylWymianaNie 
      ,vi.LinkaObrotomierzaInspekcja 
      ,vi.LinkaObrotomierzaWymianaTak 
      ,vi.LinkaObrotomierzaWymianaNie 
      ,vi.LinkaPredkosciomierzaInspekcja 
      ,vi.LinkaPredkosciomierzaWymianaTak 
      ,vi.LinkaPredkosciomierzaWymianaNie 
      ,vi.SynchronizacjaInspekcja 
      ,vi.SynchronizacjaWymianaTak 
      ,vi.SynchronizacjaWymianaNie 
      ,vi.PrzepustnicaInspekcja 
      ,vi.PrzepustnicaWymianaTak 
      ,vi.PrzepustnicaWymianaNie
      ,vi.Uwagi
      ,vi.CREDATE
      ,vi.CREUSER
      ,vi.UPDDATE
      ,vi.UPDUSER
    FROM MT_VehicleInspection AS vi with(nolock) INNER JOIN
			MT_Vehicle AS ve with(nolock) ON vi.VehicleID = ve.VehicleID
	ORDER BY vi.InspectionID desc
