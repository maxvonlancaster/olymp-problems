def _function():
    return 0

def _sequence_rule(i):
    return i

def _get_sequence(n):
    sequence = []
    for i in range(n):
        sequence.append(_sequence_rule(i))
    return sequence



