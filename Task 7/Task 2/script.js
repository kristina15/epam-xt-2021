
function word(text)
{
    var numbers=getNumbers(text);
    var res = numbers[0];
    for (let i = 0, j = 1; i < text.length; i++)
    {
        if(text[i]=="+") 
        {
            res += numbers[j];
            j++;
        }
        if(text[i]=="-")
        {
            res -= numbers[j];
            j++;
        }
        if(text[i]=="*")
        {
            res *= numbers[j];
            j++;
        }
        if(text[i]=="/")
        {
            res /= numbers[j];
            j++;
        }
    }

    alert(res.toFixed(2));
}

function getNumbers(str)
{
    var numbers = new Array();
    var num=0;
    for (let i = 0; i < str.length; i++)
    {
        if (str[i]>="0" && str[i]<="9")
        {
            num *= 10;
            num += parseInt(str[i]);
        }
        else if (str[i] == '.')
        {
            i++;
            let k = 0;
            while (str[i]>="0" && str[i]<="9")
            {
                k++;
                num *= 10;
                num += parseInt(str[i]);
                i++;
            }

            num /= (10 * k);
        }
        else
        {
            numbers.push(num);
            num = 0;
        }
    }

    return numbers;
}