# DEQUE CARD SHUFFLER
Overview
This project implements a custom Deque (double-ended queue) class with operations that allow adding and removing items from both ends of the queue. The Deque class is used in a card shuffling program to shuffle a deck of cards using a specific algorithm.

Deque Class Implementation
The Deque class supports the following methods:

EnqueueFront(Object o): Adds an item to the front of the deque.
EnqueueBack(Object o): Adds an item to the back of the deque.
DequeueFront(): Removes and returns the item from the front of the deque.
DequeueBack(): Removes and returns the item from the back of the deque.
PeekFront(): Returns the item at the front of the deque without removing it.
PeekBack(): Returns the item at the back of the deque without removing it.
Count(): Returns the number of items in the deque.
The Deque is implemented recursively with custom nodes, without relying on any built-in C# data structures such as arrays, ArrayList, or LinkedList. The operations are designed to run in constant time (O(1)).

Card Shuffling Algorithm
This program uses the Deque class to shuffle a deck of cards stored in Cards.txt. The shuffling process follows these steps:

Start with an empty pile.
Add one card from the pack to the top of the pile.
Add the next two cards to the bottom of the pile (one at a time).
Add three cards to the top of the pile (one at a time).
Add four cards to the bottom of the pile (one at a time).
Continue alternating between adding cards to the top and bottom of the pile, incrementing the number of cards added after each step.
The process stops when all cards from the deck are added to the pile.
