--create trigger AddBlogInRaytingTable
--on blogs
--after Insert 
--as 
--declare @ID int
--Select @ID = BlogID from inserted 
--Insert Into blogRaytings(BlogID,BlogTotalScore,BlogRaytingCount)
--values(@ID,0,0)
create trigger AddScoreInComment
on comments
after Insert
as 
declare @ID int 
declare @Score int
declare @RaytingCount int
Select @ID = BlogID,@Score = BlogScore From Inserted
Update blogRaytings Set BlogTotalScore =BlogTotalScore +@Score , BlogRaytingCount+=1 
where BlogID=@ID