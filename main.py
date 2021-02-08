"""
Обработать текст программы на языке C#, удалив из текста все комментарии (как однострочные, так и многострочные).
"""
counter = 1
hasComment = False
input_file = open('code.cs')
output_file = open('code_without_comments.cs', 'w')
for line in input_file:
    whiteLine = line.replace(' ', '')
    # комментарий типа //comment
    position = whiteLine.find("//")
    if position is -1:  # не найдено комментариев в строку
        pass
    else:  # найден комментарий в строку
        if position is 0:  # в месте где нет кода
            output_file.write(line[:whiteLine.find("//")])
            continue
        else:  # в месте где есть код
            output_file.write(line[:line.find("//")] + '\n')
            continue

    # комментарий типа /* comment */
    if whiteLine.find("/*") is not -1:
        hasComment = True
        continue
    if whiteLine.find("*/") is not -1:
        hasComment = False
        continue
    if hasComment is True:
        continue
    else:
        pass

    output_file.write(line)
