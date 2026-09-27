# 17. Connecting to Your Data

Before the assistant can do anything with Power BI, it has to connect to it. This
chapter is about that handshake — how the assistant finds your open report, connects
to the live model, and knows exactly what it's talking to.

## The local connection

Here is the key thing to understand: Power BI Desktop, when you open a report,
starts a small **analysis engine** on your own machine (a program called
`msmdsrv`). The assistant connects to *that* engine, on *your* machine.

```
You  →  AgentBridge  →  PowerBITool  →  the engine inside your Power BI Desktop
```

No cloud. No upload. The data never leaves your computer. The assistant is simply
talking to the same engine that Power BI itself uses, through a local door.

## Finding what's open

The assistant can see every Power BI report you have open, each with its own engine
and port:

> "Which Power BI reports are open right now?"

![Open reports](../../assets/examples/e003.png)

If you have one report open, it connects to it directly. If you have several, you
tell it which one by name. This is how it stays pointed at the right thing.

## Confirming the connection

Once connected, you can always check the status:

> "What is the connection status?"

![Connection status](../../assets/examples/e004.png)

It tells you which model it's on and which local port. This matters because every
later change goes to *this* live model. Knowing exactly what you're connected to is
the first rule of safe editing.

## What "live" really means

When the assistant changes the model, the change happens in the **live, in-memory
model** inside Power BI Desktop. You see it immediately — that's the visual
feedback loop. But there is one important catch the tool always reminds you of:

> The change is live but **not saved to the file**. To keep it, you press **Ctrl+S**
> in Power BI Desktop.

This is a safety feature, not a bug. It means every change is reversible until you
choose to save. You can experiment freely; nothing is permanent until you decide.

## A curiosity: the port is a secret door

Each Power BI Desktop instance picks a random local network port for its engine —
that number in the connection string (like `localhost:64431`). The assistant
discovers this port automatically by finding the running Power BI process and its
child engine. You never have to know the number; the tool figures it out. It's the
same door Power BI uses internally — the assistant just learned how to knock.

## Reconnecting and safety

If you close the report and open another, the assistant notices the engine changed
and asks you to reconnect — it won't blindly write to the wrong model. This
session-safety is what makes live editing trustworthy: the tool checks that the
engine behind the connection is still the one it connected to before it lets a
change through.

---

## What you'll carry from this chapter

- The assistant connects to the local engine inside your Power BI Desktop.
- No cloud, no upload — everything stays on your machine.
- It discovers open reports and their ports automatically.
- Changes are live but not saved until you press Ctrl+S.
- The tool guards against writing to the wrong model.

Next: modelling in Power BI — the assistant as a careful, well-documented modeler.
