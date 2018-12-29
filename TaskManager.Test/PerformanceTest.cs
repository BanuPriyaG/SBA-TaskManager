using NBench;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TaskManager.ServiceLayer.Controllers;
using TaskManger.Test;

namespace TaskManager.Test
{
    public class PerformanceTest
    {
        [PerfBenchmark(NumberOfIterations = 1, RunMode = RunMode.Throughput,
        TestMode = TestMode.Test, SkipWarmups = true)]
        [ElapsedTimeAssertion(MaxTimeMilliseconds = 5000)]
        public void Benchmark_Performance_ElaspedTime_User()
        {
            var user = new Users();
            user.Test_GetAllUsers();
        }

        [PerfBenchmark(NumberOfIterations = 1, RunMode = RunMode.Throughput,
        TestMode = TestMode.Test, SkipWarmups = true)]
        [ElapsedTimeAssertion(MaxTimeMilliseconds = 5000)]
        public void Benchmark_Performance_ElaspedTime_Task()
        {
            var task = new Tasks();
            task.Test_GetAllTasks();
        }

        [PerfBenchmark(NumberOfIterations = 1, RunMode = RunMode.Throughput,
        TestMode = TestMode.Test, SkipWarmups = true)]
        [ElapsedTimeAssertion(MaxTimeMilliseconds = 5000)]
        public void Benchmark_Performance_ElaspedTime_Project()
        {
            var proj = new Projects();
            proj.Test_GetAllProjects();
        }

        [PerfBenchmark(Description = "MemoryTEST",
NumberOfIterations = 5, RunMode = RunMode.Throughput, RunTimeMilliseconds = 2500, TestMode = TestMode.Test)]
        [MemoryAssertion(MemoryMetric.TotalBytesAllocated, MustBe.LessThanOrEqualTo, ByteConstants.SixtyFourKb)]
        public void Benchmark_Performance_Memory()
        {
            var task = new Tasks();
            task.Test_GetAllTasks();
        }
    }
}
