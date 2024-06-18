## Andet Udkast

### Værktøjer

1. Agile Metoder:
   - Kanban tabeller (Projects)
   - Hvordan er disse blevet brugt?
2. GitHub Projects
   - Issues

### Projekt Planlægning

3. Inception
   - Mål & Vision for projektet
4. Ellaboration
   - Krav specifikation
5. Construction
   - Construction fasens resultat vises med kode eksempler & powerpoint.
6. Testing
   - Hvorfor?
   - Hvordan? (Vis eksempler)
   - Svært i dette projekt grundet manglende "hjælpe metoder" (vis eksempel fra andet projekt)
7. Hvorfor kategorier?
   - Hvorfor dele det op i kategorier. (Nedbrydning)

### Kode eksempler

7. API lag
   - Controllers
     - Seperation of concerns
   - Dependency Injection (Program.cs)
8. Repository lag
   - DataContext
   - Repository klasse
     - Hvorfor bruger nogle controllers standard repository, og andre ikke?
     - Vigtigheden af interfaces.
   - Entity Framework
     - Hvorfor?
     - Code first tilgang
       - Hvorfor?
9. Klient
   - Design (Adobe XD)
   - Teknologi (MAUI)
     - Hvorfor?
   - MVVM (Model View Viemodel)
     - Muligt billede (TODO) _(Ellers bare forklar i PowerPoint)_
10. Service lag
    - Hvordan?
    - Hvorfor?
11. PowerPoint
    - MVVM (Måske)
      - Seperation of concerns
    - Polymorfi
      - Interfaces
        - Interfaces definerer en kontrakt, som klasser kan implementere.
        - De tillader polymorfi ved at flere klasser kan implementere samme interface og dermed behandles ens.
      - Method overloading
        - Method overloading tillader flere metoder med samme navn men forskellige parameterlister i samme klasse.
        - Bruges til at forbedre læsbarhed og genbrug af kode.
      - Generics
        - Generics tillader, at klasser og metoder kan operere på objekter af forskellige typer, mens de giver kompileringstidens type sikkerhed.
        - Anvendes til at skabe kode, der kan genbruges med forskellige datatyper uden at miste type sikkerhed.
    - Nedarvning
      - Constructor Chaining
        - Constructor chaining refererer til en situation, hvor en constructor kalder en anden constructor i samme klasse (eller superklasse).
        - Bruges til at initialisere objekter på en mere organiseret måde.
      - Method overriding
        - Method overriding gør det muligt for en subklasse at levere en specifik implementering af en metode, der allerede er defineret i dens superklasse.
        - Giver mulighed for runtime polymorfi, hvor den relevante metode kaldes baseret på objektets faktiske type.
      - Abstrakte klasser
        - Abstrakte klasser kan ikke instansieres og bruges som basisklasser for andre klasser.
        - De kan indeholde både konkrete metoder og abstrakte metoder (metoder uden en krop).
      - Abstrakte metoder
        - Abstrakte metoder er erklæret uden implementering i en abstrakt klasse.
        - Subklasser skal give en konkret implementering af disse metoder.
