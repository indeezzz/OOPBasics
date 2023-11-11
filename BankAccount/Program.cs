using ClassFabricCreateBuild;
using System.Collections;

CreatorBuild creatorBuild = new CreatorBuild();

var build = creatorBuild.CreatePanelBuild();
var build1 = creatorBuild.CreateBrickBuild();
var build2 = creatorBuild.CreateWoodenBuild();

foreach (Build builds in creatorBuild.TableBuilds.Values)
{
    Console.WriteLine(builds.Init());
}

creatorBuild.TableBuilds.Remove(build1.ID);

Console.Write("\n");
foreach (Build builds in creatorBuild.TableBuilds.Values)
{
    Console.WriteLine(builds.Init());
}

Console.ReadLine();

 