/*
Range Extraction
A format for expressing an ordered list of integers is to use a comma separated list of either
individual integers
or a range of integers denoted by the starting integer separated from the end integer in the range by a dash, '-'. The range includes all integers in the interval including both endpoints. It is not considered a range unless it spans at least 3 numbers. For example "12,13,15-17"
Complete the solution so that it takes a list of integers in increasing order and returns a correctly formatted string in the range format.
*/
 public static string Extract(int[] args)
        {
            StringBuilder sb = new StringBuilder();
            int f = 0, count = 0;
            int[] arr = new int[1000];

            for (int j = 0; j < args.Length; j++)
            {
                if (args.Length <= 3)
                {
                    if(args.Length==1)
                    {
                        sb.Append(args[j]);
                        break;
                    }
                    if(args.Length==2)
                    {
                        sb.Append(args[j] + "," +args[j+1]);
                        break;
                    }
                    if (args.Length == 3)
                    {
                        if(j==0 && args[j+1] ==args[j]+1  && args[j + 2] == args[j] + 2)
                        {
                            sb.Append(args[0] + "-" + args[2]);
                            break;
                        }
                        else
                        {
                            sb.Append(args[0] + "," + args[1] + "," + args[2]);
                            break;
                        }

                    }
                }
                else
                {
                    if (j == 0)
                    {
                        if (args[j] + 1 != args[j + 1])
                        {
                            sb.Append(args[j] + ",");
                        }
                        else
                        {
                            f = args[j];
                            arr[0] = f;
                            count++;
                        }
                    }

                    else if (j == args.Length - 1)
                    {
                        if (count == 0) sb.Append(args[j]);
                        else
                        {
                            if (count == 2)
                            {
                                if (args[j - 1] == args[j] - 1) sb.Append(f + "-" + args[j]);
                                else sb.Append(arr[0] + "," + arr[1] + "," + args[j]);
                            }
                            if (count == 1) sb.Append(f + "," + args[j]);
                        }
                    }
                    else
                    {
                        if (count == 0)
                        {
                            if (args[j] + 1 != args[j + 1] && args[j - 1] != args[j] - 1) sb.Append(args[j] + ",");
                            else
                            {
                                f = args[j];
                                count++;
                                arr[0] = f;
                            }
                        }
                        else
                        {
                            if (count == 1)
                            {
                                if (args[j] + 1 != args[j + 1])
                                {
                                    sb.Append(f + "," + args[j] + ",");
                                    count = 0;
                                }
                                else
                                {
                                    arr[1] = args[j];
                                    count++;
                                }
                            }
                            else if (args[j] + 1 != args[j + 1])
                            {
                                sb.Append(f + "-" + args[j] + ",");
                                count = 0;
                            }
                        }
                    }
                }
            }
            return Convert.ToString(sb);
        }