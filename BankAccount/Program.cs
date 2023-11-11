using ClassFabricCreateBuild;

CreatorBuild creatorBuild = new CreatorBuild();

var build = creatorBuild.CreatePanelBuild();
var build1 = creatorBuild.CreateBrickBuild();
var build2 = creatorBuild.CreateWoodenBuild();

build.Init();
build1.Init();
build2.Init();

Console.ReadLine();

 