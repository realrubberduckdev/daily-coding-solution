# daily-coding-solution
This repository is hosted as [https://www.dailycodingsolution.com/](https://www.dailycodingsolution.com/).
It contains solutions to daily coding problems provided by [Daily Coding Problem](https://www.dailycodingproblem.com/) website.

# Development
# Website generation
- Install [DocFX commandline tool](https://dotnet.github.io/docfx/tutorial/docfx_getting_started.html#2-use-docfx-as-a-command-line-tool). I use Chocolatey.
- Run command
```
docfx .\docs\docfx.json --serve
```

# Adding/modifying coding solution
- Open `src/DailyCodingSolution.sln` in IDE of your choice. I use [VS IDE](https://visualstudio.microsoft.com/).
- Build and run unit tests.

# How to contribute
## Contribute a solution
* Checkout this repo.
* Add solution and unit tests.
* Add doc comments with details of the coding problem (DocFx uses the doc comments to generate dailycodingsolution.com)
* Create pull request.
## Request a solution
You can create an issue if you need a solution and I or some other contributor will attempt to add it.