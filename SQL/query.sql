create table Articles(id int, theme text);
create table Tags(id int, name text);
create table ArticleTags(article_id int, tag_id int);

insert into Articles values(1, "Статья 1");
insert into Articles values(2, "Статья 2");
insert into Articles values(3, "Статья 3");
insert into Articles values(4, "Статья 4");
insert into Articles values(5, "Статья 5");
insert into Articles values(6, "Статья 6");

insert into Tags values(1, "Тег 1");
insert into Tags values(2, "Тег 2");
insert into Tags values(3, "Тег 3");

insert into ArticleTags values(1, 1);
insert into ArticleTags values(1, 3);
insert into ArticleTags values(2, 2);
insert into ArticleTags values(2, 3);
insert into ArticleTags values(3, 2);

select a.theme, t.name from Articles a 
left join ArticleTags at on a.id = at.article_id  
left join Tags t on t.id = at.tag_id