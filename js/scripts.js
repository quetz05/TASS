function getGuildMembers()
{

	$("#status").attr("state", "work");
	
	$("#membersGuildResult").html("");

	var key = "p8tpyrde4q9angm2zbvgqccxycaw6jsz";	
	var realm = $("#realm").val();		
	var guildName = $("#guildName").val();
		
	if(key == "" || realm == "" || guildName == "")
	{
		alert("Empty form!");
		return;
	}
	
		
	var address = "https://eu.api.battle.net/wow/guild/" + realm + "/" + guildName + "?fields=members&locale=pl_PL&apikey=" + key;

	$.getJSON(address, 
		function(data, status)
		{
			if(status == "success")
			{
				var items = [];
				$.each( data, function( key, val ) 
				{
					if(key == "members")
					{					
						$.each(val, function (k, v)
						{
							$.each(v, function (k2, v2)
							{
								items.push( "<li><b>" + k2 +"</b>: " + v2 + "</li>" );
							});
							
							
						});
					}
					else
						items.push( "<li><b>" + key +"</b>: " + val + "</li>" );
				});
				 
				$( "<ul/>", 
				{
					html: items.join( "" )
				}).appendTo( "#membersGuildResult" );
				
				$("#status").attr("state", "done");
				
			}
			else
			{
				$("#status").attr("state", "error");
				alert("ERROR! Status: " + status);
			}
		});
}