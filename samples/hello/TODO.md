## TODO

0. Replicate result.
1. Cobalt Machine from Seb.
2. Run same benchmarks assign integers to get relative speeds.
3. Understand CPU usage between ARM and AMD.
4. Setting the same write barrier and rerunning the experiment - use the Less Precise WB in AMD for comparison.
5. Understanding Patching - Maoni.
6. Talk to Andrea about the results.


## Commands

### How to Install crank

- crank can be installed by invoking: dotnet tool install Microsoft.Crank.Controller --version "0.2.0-*" --global.

### Crank Command Ref 

https://github.com/dotnet/crank/blob/main/src/Microsoft.Crank.Controller/README.md

### Machine References

https://github.com/aspnet/Benchmarks/tree/main/scenarios#profiles

### Commands 

#### AMD 

crank --config ./samples/hello/hello.benchmarks.yml --scenario hello --profile aspnet-citrine-amd --application.options.fetch true --application.timeout "3"  --application.options.dumpType full

#### ARM

crank --config ./samples/hello/hello.benchmarks.yml --scenario hello --profile aspnet-siryn-arm-lin --application.options.fetch true --application.timeout "3"  --application.options.dumpType full
