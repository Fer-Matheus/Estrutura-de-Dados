#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>

struct Stack
{
    int top;
    int *vector;
};
typedef struct Stack Stack;

Stack initStack(int length);
bool isFull(Stack *stack);
bool push(Stack *stack, int item);
int pop(Stack *stack);
void showStack(Stack *stack);
void deleteStack(Stack *stack);

int main()
{
    Stack stack = initStack(11);
    for (int i = 0; i < 11; i++)
    {
        push(&stack, i);
    }
    showStack(&stack);

    return 0;
}

Stack initStack(int length)
{
    Stack stack;
    stack.top = -1;
    stack.vector = malloc(sizeof(int) * length);
    return stack;
}
bool isFull(Stack *stack)
{
    return sizeof(stack->vector) == stack->top;
}
bool push(Stack *stack, int item)
{
    if (!isFull(&stack))
    {
        stack->vector[++stack->top] = item;
        return true;
    }
    return false;
}
int pop(Stack *stack)
{
    int aux = stack->vector[stack->top];
    stack->vector[stack->top] = NULL;
    stack->top--;
    return aux;
}
void showStack(Stack *stack)
{
    printf("There is the values in this stack:\n");
    for (int i = stack->top; i > -1; i--)
    {
        printf("%d\n", stack->vector[i]);
    }
}
void deleteStack(Stack *stack)
{
    free(stack->vector);
    free(stack);
}
