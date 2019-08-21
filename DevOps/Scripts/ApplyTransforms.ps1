Param(
    [Parameter(Mandatory = $True)] [String] $env,
    [Parameter(Mandatory = $True)] [String] $path
)

function XmlDocTransform($xml, $xdt)
{
    
    if (!$xml -or !(Test-Path -path $xml -PathType Leaf)) {
        throw "File not found. $xml";
    }
    if (!$xdt -or !(Test-Path -path $xdt -PathType Leaf)) {
        throw "File not found. $xdt";
    }

    #$scriptPath = "D:\Workspace\MB\Dev\RepositoryTest\3\RepositoryService\Src\MBRepositoryService\MBRepositoryHost"
    #(Get-Variable MyInvocation -Scope 1).Value.InvocationName | split-path -parent
    Add-Type -LiteralPath "C:\Transform\microsoft.web.xmltransform.dll"

    $xmldoc = New-Object Microsoft.Web.XmlTransform.XmlTransformableDocument;
    $xmldoc.PreserveWhitespace = $true
    $xmldoc.Load($xml);

    $transf = New-Object Microsoft.Web.XmlTransform.XmlTransformation($xdt);
    if ($transf.Apply($xmldoc) -eq $false)
    {
        throw "Transformation failed."
    }
    $xmldoc.Save($xml);
}


#$path = "D:\Workspace\MB\Dev\RepositoryTest\3\RepositoryService\Src\MBRepositoryService"
$folder = (Get-ChildItem $path -Directory).FullName 

foreach($fol in $folder)
{
    if(Test-Path "$fol\web.config" -PathType Leaf)
    {
        if(Test-Path "$fol\web.$env.config" -PathType Leaf)     
        {
            write-host "Applying Web Transforms in below folder- $env "
            Write-Host $fol            
            XmlDocTransform "$fol\web.config" "$fol\web.$env.config"
        }
    }
    if(Test-Path "$fol\app.config" -PathType Leaf)
    {
        if(Test-Path "$fol\app.$env.config" -PathType Leaf)     
        {
            write-host "Applying App Transforms in below folder- $env "
            Write-Host $fol           
            XmlDocTransform "$fol\app.config" "$fol\App.$env.config"
        }
    }
}

#XmlDocTransform "Web.config" "Web.QA.config"




