using Exercise2;
var vote = 0;
var voteTotal = 0;
bool moreVotes = true;
var post = new Post();

Console.WriteLine("Please enter the title of your post: ");
post.title = Console.ReadLine();

Console.WriteLine("Please enter the description of your post: ");
post.description = Console.ReadLine();

Console.WriteLine(post.ForumPost(post.title, post.description));

do
{
    Console.WriteLine("Type 'up' to up-vote, type 'down' to down-vote, or 'end' to finalise vote: ");
    var upVoteOrDownVote = Console.ReadLine();


    if (upVoteOrDownVote == "end")
    {
        break;
    }
    else switch (upVoteOrDownVote)
    {
        case "up":
            voteTotal += post.VoteCountAdd(vote);
            break;
        case "down":
            voteTotal += post.VoteCountSubtract(vote);
            break;
        default:
            Console.WriteLine("Please enter a valid input: 'up', 'down', or 'end': ");
            continue;
    }

} while (moreVotes);
Console.WriteLine("Your post received {0} votes!", voteTotal);