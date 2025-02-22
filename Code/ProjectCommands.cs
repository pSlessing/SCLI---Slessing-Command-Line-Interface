partial class CliHandler
{
    private void Project1Semester()
    {
        Console.WriteLine(@"This project was written in C, and it's purpose, was from a graph, where nodes had a certain popularity,
        and edges had a certain amount of traffic, to find the most optimal point to place electric charging stations
        via calculating how much traffic each stop could attract from nearby roads, due to a higher popularity.
        Press enter to continue to the Github Repository");
        Console.ReadLine();
        OpenBrowser("https://github.com/cs-23-sw-1-p1-17/ChargepointPlacementFinder");
    }

    private void Project2Semester()
    {
        Console.WriteLine(@"For my second semester, we implemented a recommendation system for groups of people, calculating which activity
        would be most suited for a certain group of people. While the server is implemented in Node.js, all of the calculation
        of vectors and optimization, is done in a seperate Python script, which Node calls, while data for ratings and users are stored and retrieved
        from an SQL database
        Press enter to continue to the Github Repository");
        Console.ReadLine();
        OpenBrowser("https://github.com/Group-Project-CS-23-P2/P2");
    }

    private void Project3Semester()
    {
        Console.WriteLine(@"For the third semester project, we collaborated with a danish porto company, as they needed a new system for time registration.
        This semester, a lot of the focus was on modelling, and following certain workflows, as well as a focus on the frontend design.
        For implementation, we used Spring to implement our backend resource server, integrating with our partners authentication server, while our frontend was hosted
        seperately for easier swapability of the backend, as that was something our partner could wish to do at a later point.
        Press enter to continue to a copy of the Github Repository");
        Console.ReadLine();
        OpenBrowser("https://github.com/pSlessing/ThirdSemesterProject");
    }

    private void Project4Semester()
    {
        Console.WriteLine(@"This is currently WIP, but our goal is to design and implement a programming language
        that targets the original Nintendo Gameboy, compiling from our own language, PENGUIN, to Rednex GameBoy Assembly.
        From there, we'll use the RGBDS toolchain to compile into ROM files.");
    }
}