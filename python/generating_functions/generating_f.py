import numpy as np
import matplotlib.pyplot as plt
import math

def _function(t):
    return t

def _generating_function(sequence, t):
    res = 0
    for i in range(len(sequence)):
        res += sequence[i] * pow(t, i)
    return res

def _sequence_rule(sequence):
    if len(sequence) == 0:
        return 1
    if len(sequence) == 1:
        return 1
    return sequence[len(sequence) - 1] + sequence[len(sequence) - 2]

def _get_sequence(n):
    sequence = []
    for i in range(n):
        sequence.append(_sequence_rule(sequence))
    return sequence

print(_get_sequence(20))

