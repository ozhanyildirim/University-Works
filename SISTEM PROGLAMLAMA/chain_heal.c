#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <unistd.h>
#include <math.h>
struct Player
{
    int x;
    int y;
    int current_pp;
    int max_pp;
    char name[100];
    int isHealed;
};
typedef struct Player Player;

char *fileFormatting(char *file)
{
    for (int i = 0; i < strlen(file); i++)
    {
        if (file[i] == ' ')
        {
            file[i] = '\n';
            int index = i + 1;
            while (file[index] == ' ')
            {
                file[index] = sizeof(NULL);
                index++;
            }
        }
    }
    return file;
}
int getPlayerCount(char *formattedFile)
{
    int rowCount = 0;
    for (int i = 0; i < strlen(formattedFile); i++)
    {
        if (formattedFile[i] == '\n')
        {
            rowCount++;
        }
    }
    rowCount++;
    return rowCount / 5;
}
char *getLine(char *formattedFile, int rowNumber, char *_row)
{

    int currentRow = 1;
    char row[100];
    int rowIndex = 0;
    for (int i = 0; i < strlen(formattedFile); i++)
    {
        if (formattedFile[i] == '\n')
        {
            currentRow++;
        }
        else if (rowNumber == currentRow)
        {
            if (formattedFile[i] != sizeof(NULL))
            {
                row[rowIndex] = formattedFile[i];
                rowIndex++;
            }
        }
    }
    row[rowIndex] = '\0';
    _row = row;
    return _row;
}
double distance(Player player1, Player player2)
{

    double x2 = pow(fabs(player1.x - player2.x), 2);
    double y2 = pow(fabs(player1.y - player2.y), 2);
    return sqrt(x2 + y2);
}
int main(int argc, char *argv[])
{
    if (argc != 6)
    {
        printf("UNEXPECTED ARGUMENTS\n");
        exit(1);
    }
    char buf[1000];
    int rowCount = 0;
    size_t bytes_read;
    bytes_read = read(STDIN_FILENO, buf, sizeof(buf) - 1);
    if (bytes_read >= 0)
    {
        buf[bytes_read] = '\0';
    }
    char *file = fileFormatting(buf);
    const int playerCount = getPlayerCount(file);
    Player players[playerCount];
    int playerIndex = 0;
    int doctor;
    for (int i = 0; i < playerCount * 5; i++)
    {

        switch ((i + 1) % 5)
        {
        case 1:
            players[playerIndex].x = atoi(getLine(file, i + 1, ""));
            break;
        case 2:
            players[playerIndex].y = atoi(getLine(file, i + 1, ""));
            break;
        case 3:
            players[playerIndex].current_pp = atoi(getLine(file, i + 1, ""));
            break;
        case 4:
            players[playerIndex].max_pp = atoi(getLine(file, i + 1, ""));
            break;
        case 0:
            strncpy(players[playerIndex].name, getLine(file, i + 1, ""), strlen(getLine(file, i + 1, "")));
            if (strlen(players[playerIndex].name) > strlen(getLine(file, i + 1, "")))
            {
                players[playerIndex].name[strlen(getLine(file, i + 1, ""))] = '\0';
            }
            if (strcmp(players[playerIndex].name, "Lokman_Hekim") == 0)
            {
                doctor = playerIndex;
            }
            players[playerIndex].isHealed = 0;
            playerIndex++;
            break;
        }
    }

    int initial_range = atoi(argv[1]);
    int jump_range = atoi(argv[2]);
    int num_jumps = atoi(argv[3]);
    int initial_power = atoi(argv[4]);
    char *_buf;
    double power_reduction = strtod(argv[5], &_buf);
    double minDistance;
    double power = (double)initial_power;
    int totalHeal = 0;
    for (int j = 0; j < num_jumps; j++)
    {
        for (int i = 0; i < playerCount; i++)
        {
            if (i == doctor)
            {
                if (players[i].isHealed == 0)
                {
                    if (players[i].current_pp < players[i].max_pp)
                    {
                        int healAmount = 0;
                        if ((players[i].current_pp + power > players[i].max_pp))
                        {
                            healAmount = players[i].max_pp - players[i].current_pp;
                            players[i].current_pp = players[i].max_pp;
                        }
                        else
                        {
                            healAmount = rint(power);
                            players[i].current_pp = players[i].current_pp + rint(power);
                        }
                        power = power * (1 - power_reduction);
                        players[i].isHealed = 1;
                        totalHeal = totalHeal + healAmount;
                        printf("%s %d \n", players[i].name, healAmount);
                    }
                }
            }
            else if (initial_range != 0)
            {

                if (distance(players[doctor], players[i]) <= (double)initial_range)
                {
                    if (players[i].isHealed == 0)
                    {
                        players[doctor].x = players[i].x;
                        players[doctor].y = players[i].y;
                        if (players[i].current_pp < players[i].max_pp)
                        {
                            int healAmount = 0;
                            if ((players[i].current_pp + power > players[i].max_pp))
                            {
                                healAmount = players[i].max_pp - players[i].current_pp;
                                players[i].current_pp = players[i].max_pp;
                            }
                            else
                            {
                                healAmount = rint(power);
                                players[i].current_pp = players[i].current_pp + rint(power);
                            }
                            power = power * (1 - power_reduction);
                            players[i].isHealed = 1;
                            totalHeal = totalHeal + healAmount;
                            printf("%s %d \n", players[i].name, healAmount);
                        }
                        initial_range = 0;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            else
            {
                if (distance(players[doctor], players[i]) <= (double)jump_range)
                {
                    if (players[i].isHealed == 0)
                    {
                        players[doctor].x = players[i].x;
                        players[doctor].y = players[i].y;
                        if (players[i].current_pp < players[i].max_pp)
                        {
                            int healAmount = 0;
                            if ((players[i].current_pp + power > players[i].max_pp))
                            {
                                healAmount = players[i].max_pp - players[i].current_pp;
                                players[i].current_pp = players[i].max_pp;
                            }
                            else
                            {
                                healAmount = rint(power);
                                players[i].current_pp = players[i].current_pp + rint(power);
                            }
                            power = power * (1 - power_reduction);
                            players[i].isHealed = 1;
                            totalHeal = totalHeal + healAmount;
                            printf("%s %d \n", players[i].name, healAmount);
                        }
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
    }
    printf("Toplam_Iyilesme %d \n",totalHeal);

    return 0;
}