using AaBbAb;

Solution sol = new Solution();

Console.WriteLine($"Test (0, 0, 0): {sol.solution(0, 0, 0)}");
Console.WriteLine($"Test (10, 0, 0): {sol.solution(10, 0, 0)}");
Console.WriteLine($"Test (0, 10, 0): {sol.solution(0, 10, 0)}");
Console.WriteLine($"Test (0, 0, 10): {sol.solution(0, 0, 10)}");
Console.WriteLine($"Test (10, 10, 0): {sol.solution(10, 10, 0)}");
Console.WriteLine($"Test (0, 10, 10): {sol.solution(0, 10, 10)}");
Console.WriteLine($"Test (10, 0, 10): {sol.solution(10, 0, 10)}");
Console.WriteLine($"Test (1, 2, 3): {sol.solution(1, 2, 3)}");
Console.WriteLine($"Test (2, 3, 1): {sol.solution(2, 3, 1)}");
Console.WriteLine($"Test (3, 1, 2): {sol.solution(3, 1, 2)}");
Console.WriteLine($"Test (3, 2, 1): {sol.solution(3, 2, 1)}");
Console.WriteLine($"Test (1, 2, 3): {sol.solution(0, 3, 7)}");
Console.WriteLine($"Test (1, 2, 3): {sol.solution(0, 7, 3)}");
Console.WriteLine($"Test (2, 3, 1): {sol.solution(3, 7, 0)}");
Console.WriteLine($"Test (3, 1, 2): {sol.solution(7, 0, 3)}");
Console.WriteLine($"Test (3, 2, 1): {sol.solution(7, 3, 0)}");
Console.WriteLine($"Test (10, 10, 10): {sol.solution(10, 10, 10)}");
