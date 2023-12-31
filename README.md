# eGym

Fitness centar je mjesto kroz koje u kratkom vremenskom periodu prodje veliki broj korisnika. Zbog svega toga potrebno je imati pouzdan sistem koji ce se baviti administracijom svih poslovnih procesa koji se odvijaju u fitness centru, a sve to naravno s ciljem poboljsanja efikasnosti pri vodjenju vec pomenutih poslovnih procesa, ali naravno i s ciljem da se korisnicima pruzi bolja usluga u smislu da korisnici mogu u par klikova uraditi sve sto je potrebno kako bi zakazali termin, istrazili svoj plan ishrane, itd...

U tu svrhu u nastavku dokumenta bit ce opisana aplikacija koja će sluziti uposlenicima fitness centra, kao i samim korisnicima istog. Aplikacija ce se sastojati od desktop dijela aplikacije koja ce biti namjenjena uposlenicima, dok ce mobilni dio aplikacije biti na usluzi korisnicima.

## Pristupni podaci

### Desktop aplikacija

Admin:
1. username = "desktop", password = "test"
2. username = "mobile", password = "test"

Uposlenik:
1. username = "employee", password = "test"
2. username = "nejlah", password = "nejla123"

### Mobile aplikacija

1. username = "user", password = "test"
2. username = "lejlah", password = "lejlah123"

Pored nabrojanih pristupnih podataka, u bazi podataka se mogu pronaci i ostali zaposlenici i korisnici.

## Konfiguracija okruženja za rad aplikacije

1. Pokrenuti komandu `git clone https://github.com/hindicamra/eGym_v3.git` u command prompt-u
2. Pozicionirati se u root folder repositorija
3. Pokrenite komandu `docker-compose build`
4. Nakon sto se prethodna komanda uspjesno izvrsi, pokrenuti komandu `docker-compose up`, nakon cega ce biti pokrenuti containeri
5. Testirati aplikacije

Ukoliko mobile aplikacija nije u mogucnosti da komunicira sa backendom, tada je potrebno podesiti BaseURL u `api_service.dart` na liniji 14(https://github.com/hindicamra/eGym/blob/b4d6572888f2c858190a056796505251642942f9/egym_ui_mobile/lib/app/services/api_service.dart#L14) fajlu i to na sljedeci nacin:
1. Otvoriti command prompt
2. Ukucati `ipconfig`
3. Kopirati IP adresu od Wireless LAN adapter Wi-Fi (IPv4 Address), te na nju dodati `:5192`

## Konekcija na bazu

Otvoriti SSMS(SQL Server Managment Studio), te izvrsiti konekciju na bazu kao na slici
![image](https://github.com/hindicamra/eGym/assets/126388697/739cbcb7-702c-4f84-8f7a-941c6c0cfa93)

Password = "QWElkj132!"

## Testiranje online payment sistema

Za testiranje payment sistema, potrebno je logirati se na Mobile aplikaciju.
Nakon sto je korisnik kreirao Rezervaciju, te neko od uposlenika mu je odobrio, omogucava mu se da izvrsi uplatu Rezervacije. 
Da bi korisnik izvrsio uplatu morat ce imati kreiran profil na Stripe sistemu, gdje ce ga aplikacija obavjestit da nema kreiran i zatraziti mu podatke da krerira profil. Nakon toga ce biti u mogucnosti klikom da izvrsi uplatu.

Online placanje je moguce izvrsiti uz pomoc sljedecih podataka:

Card number: 4242 4242 4242 4242
Security code: (bilo koji 3-cifreni)
Expiration date: (bilo koji mjesec i godina u buducnosti)

## Testiranje sistema preporuke

Sistem preporuke je integrisan prilikom kreiranja Rezervacije, na nacin koji je opisan u prijavi teme.

## Developer

## Enviroments

Dodati su Enviromenti: Prodution/Development.
Production:
	Windows Forms: gadja api od dockera
	API: gadja MS SQL server od dockera
Development:
	Windows Forms: gadja api koji se pokrene preko Visual Studija
	API: gadja MS SQL server koji smo instalirali direktno na masinu
Mozemo brzo da iz Windows Aplikacije koristimo API u Dockeru/Lokalni koji pokrenemo preko Visual Studio a isto tako i API mozemo staviti da gadja bazu u Dockeru ili lokalni SQL Server.

Promjena enviromenta:
	Visual Studio->Projekat(Win Form/API)->Properties->Debug->Open debug launch profiles UI->enviroments variables -> ASPNETCORE_ENVIRONMENT:Production/Development

## Reporti

Microsoft Report Builder:
Instalirati Microsoft Report Builder "https://www.microsoft.com/en-US/download/details.aspx?id=53613"
Data Sources dodati data source Lokalni Microsoft SQL Server/Docker Microsoft SQL Server, Name:DataSource
Datasets dodati novi dataset, Name:DataSet, Use a dataset embedded in my report., Data source: DataSource, Query designer..., Tables odabrati tabelu za prikaz i sve ili pojedinacne kolone, Ok, Ok. Na reportu desni klik Insert->Table i u tabeli ima data odabrati kolone koje zelimo prikazati i snimimo report kao nesto.rdl

C#:
Ako nisu dodani nugeti dodati ih: ReportViewerCore.WinForms, ReportViewerCore.NETCore
Prekopirati report u folder Reports. Properties od reporta->Build Action:Embedded resource
Kreirati Windows Formu-> Iz Toolbox prevuci Report Viewer.
ako imamo WinForma.cs imamo strelicu sa lijeve strane kliknemo i pojaviti ce se ispod WinFormaDesigner.cs te otvoriti taj WinFormaDesigner.cs -> Dodati u InitializeComponent() -> Controls.Add(reportViewer1); i snimiti i na formi se prikaze report viewer na property od reporta mozemo da promjenimo visinu i sirinu.
Kliknuti par puta na windows formu i da bi se kreirala metoda WinForma_Load(object sender, EventArgs e) i dodati sljedece:
            //Globalne

            private readonly APIService _service = new APIService("Account");
            List<AccountDTO> accounts = new List<AccountDTO>();

            WinForma_Load(object sender, EventArgs e) 
            {
                reportViewer1.LocalReport.ReportEmbeddedResource = "eGym.UI.Desktop.Reports.ReportKorisnici.rdl";//putanaj do reporta
                try
                {
                    accounts = await _service.Get<List<AccountDTO>>(null, "/getAll");//AccountDTO je model koji smo odabrali na dizajnu reporta

                    reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet", accounts));//DataSet mora biti istog naziva kao i u reportu
                    reportViewer1.RefreshReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Desila se greska");
                }
            }