[![Issue Stats](http://issuestats.com/github/neoeinstein/ScytheBlog/badge/issue)](http://issuestats.com/github/neoeinstein/ScytheBlog)
[![Issue Stats](http://issuestats.com/github/neoeinstein/ScytheBlog/badge/pr)](http://issuestats.com/github/neoeinstein/ScytheBlog)

# ScytheBlog [![NuGet Status](http://img.shields.io/nuget/v/ScytheBlog.svg?style=flat)](https://www.nuget.org/packages/ScytheBlog/)

**Progress:** See the Issues and Milestones pages of this repo.

**ScytheBlog** aims to be a blog-aware static site generator, mostly built in `F#`. But don't worry, you won't even
need to know any F# to get up and running. So long as you are comfortable using a command line or terminal, and have
a degree of familiarity with Markdown and Razor syntax - you're good to go!

Inspired by the likes of **Jekyll** and **Octopress** - and greatly helped along the way by the scripts behind
[@tomaspetricek](https://twitter.com/tomaspetricek)'s [personal website](https://github.com/tpetricek/TomaspNet.Website);
ScytheBlog gives the average F# and .NET hacker the tools they need to get a statically built website up and running
quickly and hosted somewhere like [GitHub Pages](http://pages.github.com/).

This set of tools have been pulled together using some of the following community projects:

* [FAKE](http://fsharp.github.io/FAKE/) for the automation and scripting of the different tasks.
* [F# Formatting](http://tpetricek.github.io/FSharp.Formatting/) which deals with the Markdown and F# processing/colorization.
* [RazorEngine](https://github.com/Antaris/RazorEngine) which is used for the templating and embedded C# code.
* Some of the code that calls *RazorEngine* from F# is based on [Tilde](https://github.com/aktowns/tilde).

## Getting started

To get started quickly, you will want to grab a fork of the [ScytheBlog site template](https://github.com/neoeinstein/ScytheBlogTemplate).

## Remarks

This project is based on the foundation provided by [FsBlog](https://github.com/fsprojects/FsBlog/) but looks to
separate the concerns of the core site generation engine from the content provided by consumers.


## Maintainer(s)

- [@neoeinstein](https://github.com/neoeinstein)
