int count = 0;
double distance = 10000;
double friend1_speed = 1, friend2_spped = 2, dog_speed = 5, friend = 2;
double time = 0; 
while (distance > 10)
{
    if (friend == 1)
    {
        time = distance / (friend1_speed + dog_speed); 
        friend = 2;
    }
    else
    {
        time = distance / (friend2_spped + dog_speed);
        friend = 1;
    }
    distance -= (friend1_speed + friend2_spped) * time;
    count += 1;
}
Console.WriteLine(count);
