#r "../../packages/Newtonsoft.Json/lib/net45/Newtonsoft.Json.dll"

#load "SchemaHandling.fs"
open SchemaHandling
// Generated by
/// bq query --format=json --dry_run=true --use_legacy_sql=false 'SELECT @a IS TRUE AS x, @b + 1 AS y, "foo" = @c AS z, ["tomas", "jansson"] as w, STRUCT("wat" as t, 69 as u) as v, [STRUCT(3, "allo" as g), STRUCT(5 as a, "yolo")] as u, STRUCT(["a"] as h) as t;'
let sample = """
{
    "status": {
        "state": "DONE"
    },
    "kind": "bigquery#job",
    "statistics": {
        "query": {
            "statementType": "SELECT",
            "totalBytesBilled": "0",
            "totalBytesProcessed": "0",
            "cacheHit": false,
            "undeclaredQueryParameters": [
                {
                    "parameterType": {
                        "type": "BOOL"
                    },
                    "name": "a"
                },
                {
                    "parameterType": {
                        "type": "INT64"
                    },
                    "name": "b"
                },
                {
                    "parameterType": {
                        "type": "STRING"
                    },
                    "name": "c"
                }
            ],
            "schema": {
                "fields": [
                    {
                        "type": "BOOLEAN",
                        "name": "x",
                        "mode": "NULLABLE"
                    },
                    {
                        "type": "INTEGER",
                        "name": "y",
                        "mode": "NULLABLE"
                    },
                    {
                        "type": "BOOLEAN",
                        "name": "z",
                        "mode": "NULLABLE"
                    },
                    {
                        "type": "STRING",
                        "name": "w",
                        "mode": "REPEATED"
                    },
                    {
                        "fields": [
                            {
                                "type": "STRING",
                                "name": "t",
                                "mode": "NULLABLE"
                            },
                            {
                                "type": "INTEGER",
                                "name": "u",
                                "mode": "NULLABLE"
                            }
                        ],
                        "type": "RECORD",
                        "name": "v",
                        "mode": "NULLABLE"
                    },
                    {
                        "fields": [
                            {
                                "type": "INTEGER",
                                "name": "_field_1",
                                "mode": "NULLABLE"
                            },
                            {
                                "type": "STRING",
                                "name": "g",
                                "mode": "NULLABLE"
                            }
                        ],
                        "type": "RECORD",
                        "name": "u",
                        "mode": "REPEATED"
                    },
                    {
                        "fields": [
                            {
                                "type": "STRING",
                                "name": "h",
                                "mode": "REPEATED"
                            }
                        ],
                        "type": "RECORD",
                        "name": "t",
                        "mode": "NULLABLE"
                    }
                ]
            }
        },
        "creationTime": "1490729738377",
        "totalBytesProcessed": "0"
    },
    "jobReference": {
        "projectId": "uc-prox-production"
    },
    "etag": "\"smpMas70-D1-zV2oEH0ud6qY21c/IWCngCv5ww2vMSLRv2GxsJsBwwU\"",
    "configuration": {
        "query": {
            "createDisposition": "CREATE_IF_NEEDED",
            "query": "SELECT @a IS TRUE AS x, @b + 1 AS y, \"foo\" = @c AS z, [\"tomas\", \"jansson\"] as w, STRUCT(\"wat\" as t, 69 as u) as v, [STRUCT(3, \"allo\" as g), STRUCT(5 as a, \"yolo\")] as u, STRUCT([\"a\"] as h) as t;",
            "writeDisposition": "WRITE_TRUNCATE",
            "destinationTable": {
                "projectId": "uc-prox-production",
                "tableId": "anon311d2e18c944c7a5c91ab469c91b33527a239a06",
                "datasetId": "_2a855e87bf6147c55e896dcce917ee0deb1bc026"
            },
            "useLegacySql": false
        },
        "dryRun": true
    },
    "user_email": "tomas.jansson@unacast.com"
}"""

//printfn "==> %A" y
parseQueryMeta sample
|> (printfn "RESULT: %A")