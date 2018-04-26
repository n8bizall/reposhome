using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithmia;

var input = "Public Sub Main(sDocumentType() As String)\r\n        Try\r\n            _dtParameters = DjjData.GetApplicationParameters(ApplicationType)\r\n\r\n            ErrorPanel.DJJ_ApplicationType = ApplicationType\r\n            ErrorPanel.DJJ_BizType = BizType\r\n            ErrorPanel.DJJ_EmailOnError = True\r\n            ErrorPanel.DJJ_EmailRecipients = DJJFunctions.GetParameterValue(_dtParameters, \"EmailOnErrorRecipients\")\r\n\r\n            Select Case sDocumentType(0)\r\n                Case \"PO\", \"SO\"\r\n                    ContractPrintFunctions.ProcessContractDocuments(BizType, \"PO\", ApplicationType)\r\n                Case \"PCO\", \"SCO\"\r\n                    ContractPrintFunctions.ProcessChangeOrderDocuments(BizType, sDocumentType(0), ApplicationType)\r\n                Case Else\r\n                    Exit Sub\r\n            End Select\r\n        Catch ex As Exception\r\n            ErrorPanel.HandleError(ex, \"PrintProcessor\")\r\n        End Try\r\n    End Sub";
	var client = new Client("simHdKHFiFfIOHy0mE3T8AwM6Kj1");
	var algorithm = client.algo("PetiteProgrammer/ProgrammingLanguageIdentification/0.1.3");
	var response = algorithm.pipe<object>(input);
	Console.WriteLine(response.result);

