using System;

// 声明委托
public delegate void WorkPerformedHandler(object sender, WorkPerformedEventArgs e);

// 定义事件参数类
public class WorkPerformedEventArgs : EventArgs
{
    public int Hours { get; set; }
    public WorkType WorkType { get; set; }
}

// 定义工作类型的枚举
public enum WorkType
{
    GoToMeetings,
    Golf,
    GenerateReports
}

public class Worker
{
    // 声明事件
    public event WorkPerformedHandler WorkPerformed;

    // 方法，用于执行工作并引发事件
    public void DoWork(int hours, WorkType workType)
    {
        // 假设做一些工作...

        // 引发事件
        WorkPerformed?.Invoke(this, new WorkPerformedEventArgs { Hours = hours, WorkType = workType });
    }
}

class Program
{
    static void Main()
    {
        Worker worker = new Worker();

        // 订阅事件
        worker.WorkPerformed += Worker_WorkPerformed;

        // 执行工作
        worker.DoWork(8, WorkType.GoToMeetings);
    }

    // 事件处理方法
    private static void Worker_WorkPerformed(object sender, WorkPerformedEventArgs e)
    {
        Console.WriteLine($"Worked {e.Hours} hours doing {e.WorkType}");
    }
}
