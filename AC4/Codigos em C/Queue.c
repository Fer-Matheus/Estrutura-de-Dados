#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>
#include <windows.h>

struct Queue
{
    int top, bottom, qtde;
    int *queue;
};

typedef struct Queue Queue;

Queue initQueue(int length, Queue *queue);
void freeQueue(Queue *queue);
bool isEmpty(Queue *queue);
bool isFull(Queue *queue);
bool inQueue(Queue *queue, int item);
bool search(Queue *queue, int item);
int deQueue(Queue *queue);
void showQueue(Queue *queue);

int main()
{
    Queue queue = initQueue(5, &queue);

    for (int i = 0; i < 10; i++)
    {
        inQueue(&queue, i);
        Sleep(30);
    }

    showQueue(&queue);

    freeQueue(&queue);

    return 0;
}

Queue initQueue(int length, Queue *queue)
{
    queue->bottom = 0;
    queue->top = 0;
    queue->qtde = 0;
    queue->queue = malloc(sizeof(int) * length);
}

void freeQueue(Queue *queue)
{
    free(queue->queue);
    free(queue);
}

bool isEmpty(Queue *queue)
{
    return queue->qtde == 0;
}
bool isFull(Queue *queue)
{
    return queue->qtde == (sizeof(queue->queue) - 1);
}
bool inQueue(Queue *queue, int item)
{
    if (!isFull(&queue))
    {
        queue->queue[queue->bottom] = item;
        queue->bottom = queue->bottom + 1 % sizeof(queue->queue);
        queue->qtde++;
        return true;
    }
    return false;
}
bool search(Queue *queue, int item)
{
    if (!isEmpty(&queue))
    {
        for (int i = queue->top; i != queue->bottom; i = ++i % sizeof(queue->queue))
        {
            if (queue->queue[i] == item)
            {
                return true;
            }
        }
        return false;
    }
    return false;
}
int deQueue(Queue *queue)
{
    if (!isEmpty(&queue))
    {
        int item = queue->queue[queue->top];
        queue->top = queue->top + 1 % sizeof(queue->queue);
        queue->qtde--;
        return true;
    }
    return false;
}
void showQueue(Queue *queue)
{
    if (!isEmpty(&queue))
    {
        if (queue->top == -1)
        {
            queue->top = 0;
        }
        for (int i = queue->top; i != queue->bottom; i = (i + 1) % sizeof(queue->queue))
        {
            printf("%d", queue->queue[i]);
        }
    }
}