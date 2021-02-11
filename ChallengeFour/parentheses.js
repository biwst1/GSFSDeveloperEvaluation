let isParenthesisClosed = function (parenthesis) {
    let stack = [];
    let openCloseMap = {
        '(': ')',
        '[': ']',
        '{': '}'
    }

    if (parenthesis.length % 2 != 0) {
        return false;
    }

    for (let i = 0; i < parenthesis.length; i++) {
        if (parenthesis[i] == '(' || parenthesis[i] == '[' || parenthesis[i] == '{') {
            stack.push(parenthesis[i]);
        }
        else {
            let open = stack.pop();
            if (parenthesis[i] != openCloseMap[open]) {
                return false;
            }
        }
    }

    if (stack.length != 0) {
        return false;
    }

    return true;
}